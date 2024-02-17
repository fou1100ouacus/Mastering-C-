using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Example
{
    public class Logger
    {

        public delegate void LogAction(string Message);//declration

        private LogAction _logAction; //object

        public Logger(LogAction action) //  costrcuctor
        {
            this._logAction = action;
        }

        public void ChangeMethod(LogAction action) 
        {
            this._logAction = action;
        }

        public void Log(string message) { this._logAction(message); }
    }



    public class Program
    {

        public static void LogToScreen(string Message)
        {
            Console.WriteLine(Message);
        }

        public static void LogToFile(string Message)
        {
            string FileName = "log.txt";
            using (StreamWriter writer = new StreamWriter(FileName, true))
            {
                writer.WriteLine(Message);
            }
        }


        static void Main(string[] args)
        {
            Logger ScreenLogger = new Logger(LogToScreen);
            Logger FileLogger = new Logger(LogToFile);

            ScreenLogger.Log("The message will be displayed on the screen.");//
            FileLogger.Log("The message will be logged to a File.");

            FileLogger.ChangeMethod(LogToScreen);
            FileLogger.Log("The message will be displayed on the screen.");//


            Console.ReadLine();
        }
    }

}
