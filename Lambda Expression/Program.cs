using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    public class Program
    {
        // delegate int SquareDelegate(int x);
                    
        static Func<int, int> square = x => x * x;

        static void Main(string[] args)
        {
            // SquareDelegate square = new SquareDelegate(SquareMethod);

            int result = square(5);        
                                                            
            Console.WriteLine("The Square of 5 is: " + result);
            Console.ReadLine();
        } 
    }

}
