using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    internal class Program
    {
        static void ConcatenateStrings(int iterations)
        {
            string result = "";
            for (int i = 0; i < iterations; i++)
            {
                result += "a";
            }
        }

        static void ConcatenateStringBuilder(int iterations)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }
            string result = sb.ToString();
        }

        static void Main(string[] args)
        {
            int Iterations = 200000;
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            ConcatenateStrings(Iterations);
            stopwatch1.Stop();
            Console.WriteLine($"ConcatenateStrings took : {stopwatch1.ElapsedMilliseconds}");

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            ConcatenateStringBuilder(Iterations);
            stopwatch2.Stop();
            Console.WriteLine($"ConcatenateStrings took : {stopwatch2.ElapsedMilliseconds}");

            Console.ReadKey();

            //            عشان كده عملوا حاجه تانيه اسمها string builder وده mutable datatype
            //فكرته انه بيعمل buffer بحيث انك تقدر تعدل عال string ولو ال buffer ده اتملي بيعمل copy ويضيف عليه
            // idea of stringbuilder (mutable datatype) : that using buffer 
            // is a class provided from .net framwork


        }
    }
}
