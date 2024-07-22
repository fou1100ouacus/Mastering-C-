using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAfileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Example1();
            //   Example2();
            //  Example4();
            // Example5();
            //  Example6();
            Example8();
        }
        public static void Example8()
        {
            string filePath = "D:\\File Handling C sharp\\file4.txt";
            // string[] lines =
            // {
            //     "aadffsd",
            //     "fdklfjlsk",
            //     "dfklsjkf",
            //     "uiiii"
            // };

            //File.WriteAllLines(filePath, lines);
            //string lines = "dfksfhjksdfhksjhfkjshfksjdh    fkjfh kjhjk     fhkjsfk";
            //File.WriteAllText(filePath, lines);
          var result=  File.ReadAllText(filePath);
            Console.WriteLine(result);
            // File.ReadAllLines()
 
        
        }

        public static void Example7()
        {
            string filePath = "D:\\File Handling C sharp\\file4.txt";
            // string[] lines =
            // {
            //     "aadffsd",
            //     "fdklfjlsk",
            //     "dfklsjkf",
            //     "uiiii"
            // };

            //File.WriteAllLines(filePath, lines);
            string lines = "dfksfhjksdfhksjhfkjshfksjdh    fkjfh kjhjk     fhkjsfk";
            File.WriteAllText(filePath, lines);


        }

        public static void Example5()
        {
            string filePath = "D:\\File Handling C sharp\\file4.txt";
            using (var sr= new StreamReader(filePath))
            {
                while (sr.Peek()>0)
                {
                    Console.WriteLine((char)sr.Read());
                }
                
               
            }
        }
        public static void Example6()
        {
            string filePath = "D:\\File Handling C sharp\\file4.txt";
            using (var sr = new StreamReader(filePath))
            { string line;
                while ((line=sr.ReadLine())!=null)   // is not null <== update version
                {
                    Console.WriteLine(line);
                }


            }
        }

        public static void Example4()
        {
            string filePath = "D:\\File Handling C sharp\\file4.txt";
            using (var sw = new StreamWriter(filePath))
            {

                sw.WriteLine("hallo");
                sw.WriteLine("hallo"); sw.WriteLine("hallo");
            }
        }

        public static void Example3()
        {
            string filePath = "D:\\File Handling C sharp\\file4.txt";
            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            { 
            
               fs.Seek(20, SeekOrigin.Begin);
                fs.WriteByte(65);
            fs.Position = 0;
                for (int i = 0; i < fs.Length; i++)
                {
                    Console.WriteLine(fs.ReadByte());
                }
            
            
            }
        }

          public static void Example2()
        {

            string filePath = "D:\\File Handling C sharp\\Handle.txt";
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] data = new byte[fs.Length];
                int NumbytesToRead = (int)fs.Length;//22
                int numbytesRead = 0;
                while (NumbytesToRead > 0)
                {                  // between 0 to 22
                    int n = fs.Read(data, numbytesRead, NumbytesToRead); // according to your pc Buffer
                    if (n == 0)
                    {
                        break;// file ended
                    }
                    NumbytesToRead -= n;
                    numbytesRead += n;//selected bytes to read
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }

                }


                /// create new file has 
                /// 
                string newPath = "C:\\Users\\HP\\OneDrive\\Desktop\\file2.txt";
                using (var fs2 = new FileStream(newPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                  fs2.Write(data, 0, data.Length);
              

                }


            }
        
        }
          public  static void Example1()
          {
            string filePath = "C:\\Users\\HP\\OneDrive\\Desktop\\file.txt.txt"; // Finally 
             using (var fs=new FileStream(filePath,FileMode.Open,FileAccess.Read))
             {


                Console.WriteLine("Length" + fs.Length);
                Console.WriteLine("Length" + fs.CanRead);
                Console.WriteLine("Length" + fs.CanWrite);
                Console.WriteLine("Length" + fs.CanSeek);
                Console.WriteLine("Length" + fs.Position);// cursor
                Console.WriteLine("Length" + fs.CanTimeout);
                fs.WriteByte(65);//A
                Console.WriteLine("position"+fs.Position);
                fs.WriteByte(66);//B
                fs.WriteByte(13);//Enter  , 10 = space

                for (byte i = 65; i <=123;i++)
                {
                    fs.WriteByte((byte)i);

                }

             }
        }
    }
}
