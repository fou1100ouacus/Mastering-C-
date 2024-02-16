using System.IO;

namespace TemperatureChangeEventExample
{
    public class Program
    {
        static Predicate<int> isEvenPredicate = isEven;

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
