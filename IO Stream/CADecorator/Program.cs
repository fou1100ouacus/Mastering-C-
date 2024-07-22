using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var s = File.Create("newfileDecorator.bin"))
            {
                using(var ds=new DeflateStream(s, CompressionMode.Compress ))
                {
                    ds.WriteByte(33);
                    ds.WriteByte(65);

                }

            }

            using (var s = File.Create("newfileDecorator.bin"))
            {
                using (var ds = new DeflateStream(s, CompressionMode.Compress))
                {
                    for (int i = 0;i<s.Length;i++)
                    {
                        Console.WriteLine(ds.ReadByte  () );
                    }
                }

            }
        }
    }
}
