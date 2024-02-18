using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
[Serializable]
public class clsPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
}

namespace XML_Serialization_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person = new clsPerson { Name = "Mohammed", Age = 40 };

            XmlSerializer Serializer = new XmlSerializer(typeof(clsPerson));

            using (TextWriter writer = new StreamWriter("person.xml"))
            {
                Serializer.Serialize(writer, person);
            }

            using (TextReader reader = new StreamReader("person.xml"))
            {
                clsPerson DeserializedPerson = (clsPerson)Serializer.Deserialize(reader);
                Console.WriteLine($"Name: {DeserializedPerson.Name}, Age: {DeserializedPerson.Age}");
            }

            Console.ReadLine();

        }
    }
}
