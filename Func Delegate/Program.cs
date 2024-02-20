using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegate
{
    internal class Program
    {
        // delegate int SquareDelegate(int x);
        static Func<int, int> square = SquareMethod;
        static int SquareMethod(int x)
        {
            return x * x;
        }


        static void Main(string[] args)
        {
          //  SquareDelegate square = new SquareDelegate(SquareMethod);

            int result = square(7);

            Console.WriteLine("The Square of 5 is: " + result);
            Console.ReadLine();
        }

    }
}
