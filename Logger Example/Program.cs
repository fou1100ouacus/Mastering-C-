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
        static Predicate<int> isEvenPredicate = isEven;

        static bool isEven(int x)
        {
            return x % 2 == 0;
        }
        static Func<int, int> square =  x => x * x;
        public delegate void LogAction(string Message);//declration

        private LogAction _logAction; //object

        public Logger(LogAction action) //  costrcuctor ==> name func will be here
        {
            this._logAction = action;
        }

        public void ChangeMethod(LogAction action) 
        {
            this._logAction = action;
        }
        public void AddMethod(LogAction action)
        {
            this._logAction += action;
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
            Logger ScreenLogger = new Logger(LogToScreen);// name fuction as a pointer
            Logger FileLogger = new Logger(LogToFile);

            ScreenLogger.Log("The message will be displayed on the screen.");//
            FileLogger.Log("The message will be logged to a File.");

            FileLogger.ChangeMethod(LogToScreen);
            FileLogger.Log("The message will be displayed on the screen.");//


            Console.ReadLine();
            ///

            Action ParameterLessAction = () => {
                Console.WriteLine("ParameterLessAction");
            };

            Action<int> ActionWith_int_Parameter = (num) => {
                Console.WriteLine($"ParamameterLessMethod {num}");
            };

            Action<string, int> ActionWithMultipleParameters = (z, x) => {
                Console.WriteLine($"{z} {x}");
            };

            ParameterLessAction();
            ActionWith_int_Parameter(42);
            ActionWithMultipleParameters("Hi", 100);
            Console.ReadLine();

        }
    }

}
