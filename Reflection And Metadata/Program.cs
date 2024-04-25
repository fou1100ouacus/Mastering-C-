using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_And_Metadata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Type t1= DateTime.Now.GetType();
            Console.WriteLine(t1);
            Type t2=typeof(DateTime);
            Console.WriteLine(t2);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.IsValueType);
            Console.WriteLine(t1.Namespace);
            Console.WriteLine(t1.IsAbstract);
            Console.WriteLine(t1.IsPublic);

            Console.WriteLine(t2);


            Type t3 = typeof(int[,]);
            Console.WriteLine(t3.Name);
        }
    }
}
