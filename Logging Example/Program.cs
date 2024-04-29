using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging_Example
{ 
    internal class Program
    {
        static void Main(string[] args)
        {// Specify the source name for the event log
            string sourceName = "MyApp";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event source created.");
            }


            // Log an information event
            EventLog.WriteEntry(sourceName, "This is an information event.", EventLogEntryType.Information);

            EventLog.WriteEntry(sourceName, "This is my warning ", EventLogEntryType.Warning);
            EventLog.WriteEntry(sourceName, "This is Error ", EventLogEntryType.Error);

            Console.WriteLine("Event written to the log.");



//            Event source created.
//Event written to the log.
        }
    }
}
