using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    internal class Program
    {
        public class GenericBox<T>
        {
            private T content;


            public GenericBox(T value)
            {
                content = value;
            }


            public T GetContent()
            {
                return content;
            }
        }

        static void Main(string[] args)
        {
            GenericBox <string> objectt=new GenericBox<string> ("llab");
            Console.WriteLine(objectt.GetContent());
        }
    }
}
