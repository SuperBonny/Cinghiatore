using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;

namespace Cinghiatore
{
  public class Session
    {
        public string Port { get; set; }
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

        public int Mode { get; set; }
        public TimeSpan Time { get; set; }
        public bool IsCountDown { get; set; }
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

        Stopwatch watch;
        Timer serialHandler;

        public event EventHandler<SerialEventArgs> onNewData;

        SerialPort arduino = new SerialPort();
        public List<Tuple<double, double>> values = new List<Tuple<double, double>>();
        double max, min;

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
            serialHandler.Interval = 200;
            serialHandler.Elapsed += serialHandler_Elapsed;
            watch = new Stopwatch();
            max = int.MinValue;
            min = int.MinValue;
        }

        void serialHandler_Elapsed(object sender, ElapsedEventArgs e)
        {
            double val = Read();
            double time = watch.ElapsedMilliseconds;

            values.Add(new Tuple<double, double>(time, val));
            onNewData(this, new SerialEventArgs(new Tuple<double, double>(time, val)));

            if (watch.Elapsed.Ticks >= Time.Ticks)
                Stop();

            if (val > max)
                max = val;

            if (val < min)
                min = val;
        }

        double Read()
        {
            try
            {
                arduino.Write("r");
                return Convert.ToDouble(arduino.ReadLine().Replace(".", ","));
            }
            catch (Exception ex)
            {
                throw new IOException(ex.Message);
            }
        }

        public string tempo()
        {
            if(IsCountDown)
                return String.Format("{0:00}:{1:00}", Time.Minutes - watch.Elapsed.Minutes, Time.Seconds - watch.Elapsed.Seconds);
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
        }

        public bool Started()
        {
            if (watch.ElapsedTicks > 0)
                return true;
            else
                return false;
        }

        public void Stop()
        {
            watch.Stop();
            serialHandler.Stop();
        }

        public void Reset()
        {
            watch.Stop();
            serialHandler.Stop();
            watch.Reset();
            values.Clear();
            max = int.MinValue;
        }

        public bool Save(string path)
        {
            File.AppendAllText(path, String.Format("Tempo [ms];Forza [Kg];Media[Kg]\n;;{0:0.00}", Math.Round(average(), 2)));

            foreach (Tuple<double, double> val in values)
                File.AppendAllText(path, Math.Round(val.Item1 / 1000, 2) + ";" + val.Item2 + Environment.NewLine);
            return true;
        }

        public bool Tare()
        {
            arduino.WriteLine("t");
            return true;
        }

        double readAverage(int reads)
        {
            double tmp = 0.0;

            for (int i = 0; i < reads; i++)
            {
                arduino.Write("r");
                tmp += Convert.ToDouble(arduino.ReadLine().Replace(".", ","));
            }
            return tmp / reads;
        }

        public double average()
        {
            double tmp = 0.0;

            foreach (Tuple<double, double> val in values)
            {
                tmp += val.Item2;
            }

            return Math.Round(tmp / values.Count, 2);
        }

        public double maxVal()
        {
            return max;
        }

        public double minVal()
        {
            return min;
        }
    }

    enum SessionMode
    {
        Libero = 0,
        Massimale = 1,
        Resistenza = 2
    }

    public class SerialEventArgs : EventArgs
    {
        public Tuple<double, double> Value { get; set; }

        public SerialEventArgs(Tuple<double, double> val)
        {
            Value = val;
        }
    }
}
