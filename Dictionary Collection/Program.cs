using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary1 = new Dictionary<string, int>()
            {
                { "3" ,5},
                { "e" ,4},
                { "f" ,3},

            };
            Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
          //  var x=dictionary1.Keys = d => d * d;
//dictionary2 = (, dictionary1.Values);


            Dictionary<string,string> capitals= new Dictionary<string ,string>()  ;
            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                {10 ,"aya" },
                {1 ,"mohamed" },
                {12 ,"awaad" },
                {13 ,"ali" },
                {15 ,"ahmed" },


            };

            var fruits = new Dictionary<int, string>()
            {
                {13 ,"apple" },
                {12 ,"banana" },
                {1 ,"watermellon" },
            };
            capitals.Add("egypt", "cairo");
            capitals.Add("dfsdf", "dfsf");

            Console.WriteLine(capitals["egypt"]);
            // try get value without error
            capitals.TryGetValue("dfjdfh",out string searchresult);
            if (searchresult !=null)
            {
                Console.WriteLine(searchresult);


            }
            else
            {
                Console.WriteLine("not found");
            }

        }
    }
}
