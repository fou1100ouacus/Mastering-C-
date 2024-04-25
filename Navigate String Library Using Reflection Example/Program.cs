using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Navigate_String_Library_Using_Reflection_Example
{
    internal class Program
    {
        static void Main(string[] args)
        { // Get the assembly containing the System.String type
            Assembly mscorlib = typeof(string).Assembly;


            // Get the System.String type
            Type stringType = mscorlib.GetType("System.string");


            if (stringType != null)
            {
                Console.WriteLine($"Methods of the System.String class:\n");


                // Get all public methods of the System.String class
                var stringMethods = stringType.GetMethods(BindingFlags.Public | BindingFlags.SuppressChangeType)
                    .OrderBy(method => method.Name);// .order by usin linq


                foreach (var method in stringMethods)
                {
                    Console.WriteLine($"\t{method.ReturnType} {method.Name} " +
                        $"({GetParameterList(method.GetParameters())})");
                }
            }
            else
            {
                Console.WriteLine("System.String type not found.");
            }


            Console.ReadKey();


        }

        static string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }
    }
}
