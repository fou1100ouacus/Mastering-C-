using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsolete_Attribute
{
    internal class Program
    {
        public class MyClass
        {
            [Obsolete("This method is marked as obsolete, and will be deprecated in the future.")]
            public void Method1()
            {
                Console.WriteLine("This method is marked as obsolete, and will be deprecated in the future.");
            }


            public void Method2()
            {
                Console.WriteLine("This is the recommended method to use.");
            }
        }
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();


            // Deprecated method usage
            myObject.Method1(); // Generates a compiler warning


            // New method usage
            myObject.Method2();


            Console.ReadLine();
        }
    }
}
