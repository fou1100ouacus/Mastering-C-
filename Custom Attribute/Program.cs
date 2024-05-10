using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute
{
    internal class Program
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
        public class MyCustomAttribute : Attribute
        {
            public string Description { get; }


            public MyCustomAttribute(string description)
            {
                Description = description;
            }
        }


        [MyCustom("This is a class attribute")]
        class MyClass
        {
            [MyCustom("This is a method attribute")]
            public void MyMethod()
            {
                Console.WriteLine("hdfjkhkdjfh");
                // Method implementation
            }
        }
        static void Main(string[] args)
        {
            //You can then use reflection or other mechanisms to access and utilize the information
            //    provided by these custom attributes at runtime.Custom attributes are often 
            //    used for various purposes such as code generation, documentation, or influencing the behavior of frameworks and libraries.



        }
    }
}
