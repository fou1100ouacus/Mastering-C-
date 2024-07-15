using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {class person
        {
            public string name { get;set;}
            public int age { get;set;}
        }
        static void Main(string[] args)
        {
            List<person> people = new List<person>()
            {
                new person {name="lkkj" ,age=10},
                new person{name="df",age=34},
                new person{name="df",age=9},
                new person{name="d3f",age=3},
                new person{name="df",age=32},
            };
            var sorted=people.OrderBy(p => p.age).ToList();// ascending order ==> from min to max
            Console.WriteLine(sorted);
            foreach (var item in sorted)
            {
                Console.WriteLine(item.age);


            }
        }
    }
}
