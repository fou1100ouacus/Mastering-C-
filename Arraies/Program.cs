using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];
            array[0] = "aya0";
            array[1] = "aya1";
            array[2] = "aya2";


            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //////
            int[] array2 = new int[3] {1,2,3 };
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
            ///// the performace of new array slices2 is better than array [time life span]
          //    var slices = 2..^2;
          //  var slices2 = array[slices];

            //var slices = array[1..2];starting from 1 take until 2 ==> 3



        }
    }
}
