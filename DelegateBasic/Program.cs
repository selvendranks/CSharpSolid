using System;

namespace DelegateBasics
{
    class Program
    {
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            Log log = new Log();

            LogDel LogTextToScreen, LogTextToFile;

            LogTextToScreen = new LogDel(log.LogTextToScreen);
            LogTextToFile = new LogDel(log.LogTextToFile);

            LogDel multiLogDel = LogTextToFile + LogTextToScreen;

            Console.WriteLine("Please enter your name");

            var name = Console.ReadLine();
            
            LogText(multiLogDel , name);

        }

        static void LogText(LogDel logDel, string text)
        {
            logDel(text);
        }

    }

    class Log
    {
        public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }

    }
}