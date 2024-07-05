using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_ExplicitCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 34;
            long num2 = num; // implicit
            long nl = 1000;
            if(nl <= Int32.MaxValue )
            {
                int n2 =(int)nl;


            }
            // converting form min to max is always a problem
            int a = 3; //value type
            object obj;// reference
            obj =a ;// converting complicity from datatype value to reference
            int b = (int)obj; // unboxing
            // int to string
            string str = "434343544069843";
            if(int.TryParse(str,out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("invalid number ");
            }
        }
    }
}
