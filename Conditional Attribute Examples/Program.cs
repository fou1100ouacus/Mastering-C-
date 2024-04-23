//#define TRACE_ENABLED


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Conditional_Attribute_Examples
{
    internal class Program
    {
        public class MyClass
        {
            [Conditional("DEBUG")]
            public void DebugMethod()
            {
                Console.WriteLine("Debug method executed.");
            }


            public void NormalMethod()
            {
                Console.WriteLine("Normal method executed.");
            }
        }
        public class TraceExample
        {
          [Conditional("TRACE_ENABLED")]
            public static void LogTrace(string message)
            {
                Console.WriteLine($"[TRACE] {message}");
            }


            static void Main(string[] args)
            {
                MyClass myClass = new MyClass();


                // Call the methods
                myClass.DebugMethod();  // This will only be executed in DEBUG builds
                myClass.NormalMethod(); // This will always be executed

                ////////////
                ///
                LogTrace("lllllllllabbbbbb");
                
                //     LogTrace("This trace message will only be included if TRACE_ENABLED is defined.");

                //  example.lo

                Console.ReadLine();
            }
        }
    }
}
