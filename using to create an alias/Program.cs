using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace using_to_create_an_alias
{
    // creating alias for System.Console
    using Koko = System.Console;

    namespace HelloWorld
    {

        class Program
        {
            static void Main(string[] args)
            {

                double n = Sqrt(9);
                Console.WriteLine("Square root of 9 is " + n);

                // using Koko alias instead of System.Console
                Koko.WriteLine("Hello World!");
                Koko.ReadKey();
            }
        }
    }

}
