using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_is_Multicast_Delegate
{
    internal class Program
    {
        public class Logger
        {

            public delegate void LogAction(string Message);//declration

            private LogAction _logAction; //object
            public void AddMethod(LogAction action)
            {
                this._logAction += action;
            }

            //public Logger(LogAction action) //  costrcuctor
            //{
            //    this._logAction = action;
            //}

            public void ChangeMethod(LogAction action)
            {
                this._logAction = action;
            }

            public void Log(string message) { this._logAction(message); }
        }



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
            Logger Logger = new Logger();

            Logger.AddMethod(LogToScreen);
            Logger.AddMethod(LogToFile);

            Logger.Log("The message will be displayed on the screen.{115}");

            //Logger ScreenLogger = new Logger(LogToScreen);
            //Logger FileLogger = new Logger(LogToFile);

            //ScreenLogger.Log("The message will be displayed on the screen.");//
            //FileLogger.Log("The message will be logged to a File.");

            //FileLogger.ChangeMethod(LogToScreen);
            //FileLogger.Log("The message will be displayed on the screen.");//


            Console.ReadLine();
            }
        }
    
}
