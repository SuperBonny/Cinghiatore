using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Timers;

namespace Cinghiatore
{
    public class Session
    {
        double max, min;
        Stopwatch watch;
        Timer serialHandler;
        SerialPort arduino = new SerialPort();
        List<double[]> values = new List<double[]>();
        public event EventHandler<SerialEventArgs> NewData;
        public event EventHandler RunningChanged;
        public string Port { get; set; }
        public SessionMode Mode { get; set; }
        public TimeSpan Time { get; set; }
        public double Max { get { return max; } }
        public double Min { get { return min; } }
        public List<double[]> Values { get { return values; } }
        public bool IsCountDown { get; set; }
        public double Average
        {
            get
            {
                double tmp = 0;
                foreach (double[] v in values)
                    tmp += v[1];
                return tmp / values.Count;
            }
        }
        public int BaudRate
        {
            get
            {
                return arduino.BaudRate;
            }
            set
            {
                arduino.BaudRate = value;
        }
        }
        public bool IsStarted
        {
            get
            {
                return serialHandler.Enabled;
            }
        }
        public double Interval
        {
            get
            {
                return serialHandler.Interval;
            }
            set
            {
                serialHandler.Interval = Convert.ToInt32(value);
            }
        }

        //Singleton Pattern
        static Session instance;
        public static Session SessionInstance
        {
            get
            {
                if (instance == null)
                    instance = new Session();
                return instance;
            }
        }

        Session()
        {
            serialHandler = new Timer();
            watch = new Stopwatch();
            serialHandler.Elapsed += serialHandler_Elapsed;
            arduino.DataReceived += arduino_DataReceived;
            SetDefaults();
            arduino.BaudRate = 115200;
            serialHandler.Interval = 200;
            Mode = 0;
            Time = TimeSpan.Zero;
        }

        void SetDefaults()
        {
            max = double.MinValue;
            min = double.MaxValue;
        }

        void arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            double val = Convert.ToDouble(((SerialPort)sender).ReadLine().Replace(".", ","));
            double time = watch.ElapsedMilliseconds;

            values.Add(new double[] { time, val });

            if (val > max)
                max = val;
            if (val < min)
                min = val;

            if(IsStarted)
                NewData(this, new SerialEventArgs(new double[] { time, val }));

            if (watch.Elapsed.Ticks >= Time.Ticks)
                Stop();
        }

        void serialHandler_Elapsed(object sender, ElapsedEventArgs e)
        {
            Read();
        }

        public bool Read()
        {
                arduino.Write("r");
                return true;
            }

        public string GetTime()
        {
            if (IsCountDown)
                return String.Format("{0:00}:{1:00}", Time.Subtract(watch.Elapsed).Minutes, Time.Subtract(watch.Elapsed).Seconds);
            else
                return String.Format("{0:00}:{1:00}", watch.Elapsed.Minutes, watch.Elapsed.Seconds);
        }

        public bool Connect()
        {
            try
            {
                if (arduino.IsOpen)
                    arduino.Close();
                arduino.PortName = Port;
                arduino.BaudRate = BaudRate;
                arduino.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Connect(string port, int baudRate)
        {
            Port = port;
            BaudRate = baudRate;
            return Connect();
        }

        public void Start()
        {
            serialHandler.Start();
            watch.Start();
            RunningChanged(this, null);
        }

        public void Stop()
        {
            watch.Stop();
            serialHandler.Stop();
            RunningChanged(this, null);
        }

        public void Reset()
        {
            Stop();
            watch.Reset();
            values.Clear();
            SetDefaults();
        }

        public bool Tare()
        {
            arduino.Write("t");
            Reset();
            Start();
            return true;
        }
    }

    public enum SessionMode
    {
        Libero = 0,
        Massimale = 1,
        Resistenza = 2
    }

    public class SerialEventArgs : EventArgs
    {
        public double[] Value { get; set; }
        public SerialEventArgs(double[] val)
        {
            Value = val;
        }
    }
}
