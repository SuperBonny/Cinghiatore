﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
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

        double max, min;
        public double Max { get { return max; } }
        public double Min { get { return min; } }
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
        public List<double[]> Values { get { return values; } }
        public bool IsCountDown { get; set; }
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

        Stopwatch watch;
        Timer serialHandler;

        public event EventHandler<SerialEventArgs> NewData;

        SerialPort arduino = new SerialPort();
        List<double[]> values = new List<double[]>();

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
        }

        void SetDefaults()
        {
            serialHandler.Interval = 200;
            arduino.BaudRate = 115200;
            Time = TimeSpan.Zero;
            max = double.MinValue;
            min = double.MaxValue;
            Mode = 0;
        }

        void arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            double val = Convert.ToDouble(((SerialPort)sender).ReadLine().Replace(".", ","));
            double time = watch.ElapsedMilliseconds;

            values.Add(new double[] { time, val });
            NewData(this, new SerialEventArgs(new double[] { time, val }));

            if (val > max)
                max = val;
            if (val < min)
                min = val;

            if (watch.Elapsed.Ticks >= Time.Ticks)
                Stop();
        }

        void serialHandler_Elapsed(object sender, ElapsedEventArgs e)
        {
            Read();
        }

        public void Read()
        {
            arduino.Write("r");
        }

        public string GetTime()
        {
            if (IsCountDown)
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
        }

        public bool Tare()
        {
            arduino.Write("t");
            Reset();
            Start();
            return true;
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
        public double[] Value { get; set; }
        public SerialEventArgs(double[] val)
        {
            Value = val;
        }
    }
}
