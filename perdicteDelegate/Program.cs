using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perdicteDelegate
{
    
   
        public class Program
        { 
             static Predicate<int> isEvenPredicate = isEven ;

            static bool isEven(int x)
            {
                return x % 2 == 0;
            }
            static void Main(string[] args)
            {
                bool result = isEvenPredicate(5);

                Console.WriteLine(result);

                Console.ReadLine();
            }


        }
    


}
