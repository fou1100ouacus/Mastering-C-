using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action ParameterLessAction = ParamameterLessMethod;
            Action<int> ActionWith_int_Parameter = MethodWith_int_Parameter;
            Action<string, int> ActionWithMultipleParameters = MethodWithMultipleParameters;

            ParameterLessAction();
            ActionWith_int_Parameter(42);
            ActionWithMultipleParameters("Hi", 100);
            Console.ReadLine();
        }

        static void ParamameterLessMethod()
        {
            Console.WriteLine("ParameterLessAction");
        }

        static void MethodWith_int_Parameter(int num)
        {
            Console.WriteLine($"ParamameterLessMethod {num}");
        }
        static void MethodWithMultipleParameters(string z, int x)
        {
            Console.WriteLine($"{z} {x}");
        }

    }
}
