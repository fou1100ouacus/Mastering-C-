using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_to_use_App.config_Examlpe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            string logLevel = ConfigurationManager.AppSettings["LogLevel"];
            string koko = ConfigurationManager.AppSettings["koko"];

            string MyDbConnection = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            Console.WriteLine("\nConnectionString = " + connectionString);
            Console.WriteLine("\nlogLevel = " + logLevel);
            Console.WriteLine("\nkoko = " + koko);

            Console.WriteLine("\nMyDbConnection = " + MyDbConnection);

            Console.ReadKey();

        }
    }
}
