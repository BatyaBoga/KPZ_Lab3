using System;
using System.IO;

namespace KPZ_Lab3 {
    public sealed class Logger
    {
        private static Logger instance = null;
        private static readonly object padlock = new object();
        private string logFilePath;

        private Logger()
        {
            logFilePath = "log.txt";
        }

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void Log(string message)
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"{DateTime.Now.ToString()} - {message}");
            }
        }
    }
}

