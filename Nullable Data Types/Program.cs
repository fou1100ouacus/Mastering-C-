using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Data_Types
{
    internal class Program
    {
        class NullableExample
        {
            static void Procedure1(string name, Nullable<int> Age)
            {

                Console.WriteLine(name);

                if (Age.HasValue)
                {
                    Console.WriteLine(Age.ToString());
                }
                else { Console.WriteLine("Age is null"); }
            }

            static void Procedure2(string name, int? Age)
            {
                Console.WriteLine(name);

                if (Age.HasValue)
                {
                    Console.WriteLine(Age.ToString());
                }
                else { Console.WriteLine("Age is null"); }
            }


            static void Main(string[] args)
            {
                Procedure1("Mohamed", null);
                Procedure1("Aly", 35);

                Procedure2("Mohamed", null);
                Procedure2("Ali", 35);

            }
        }

    }
}