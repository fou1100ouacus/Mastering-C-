using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mutable_and_Immutable_Types.Program;

namespace Mutable_and_Immutable_Types
{
    internal class Program
    {
        public class ImmutablePerson
        {
            public string Name { get; }
            public int Age { get; }


            public ImmutablePerson(string name, int age)
            {
                Name = name;
                Age = age;
            }

        }
        public class MutablePerson
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            //pros and cons of mutable and immutable
            //  Immutable Types:
            //    •	Definition: Immutable types are types whose instances cannot be modified after they are created.
            //      o Characteristics:Properties or fields of an immutable type cannot be changed after the instance is created.
            //      o Any operation that appears to modify the instance actually returns a new instance with the desired changes.
            //      o Examples include strings, tuples, and some built-in value types.
            //Example of an immutable class in C#:

            // Mutable example
            MutablePerson person1 = new MutablePerson { Name = "Alice", Age = 30 };
            person1.Age = 31; // Mutable state change


            // Immutable example
            ImmutablePerson person2 = new ImmutablePerson("Bob", 25);
            // person2.Age = 26; // Compiler error - immutable type
            ImmutablePerson newPerson = new ImmutablePerson(person2.Name, 26); 

            // Creating a new instance with the desired change
            //  • Definition: Immutable types are types whose instances cannot be modified after they are created.
            //   o Characteristics:Properties or fields of an immutable type cannot be changed after the instance is created.
            //   o Any operation that appears to modify the instance actually returns a new instance with the desired changes.
            //   o Examples include strings, tuples, and some built-in value types

        }
    }
}
