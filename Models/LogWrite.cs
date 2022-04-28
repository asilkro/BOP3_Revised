using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Silkroski_C969_Revised.Models
{
    public class LogWrite
    {
        public static void WriteToLog(string v)
        {
            using (StreamWriter w = File.AppendText("Activity_Log.txt"))
            {
                Log("Test1", w);
                Log("Test2", w);
            }

            using (StreamReader r = File.OpenText("Activity_Log.txt"))
            {
                DumpLog(r);
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    // The example creates a file named "log.txt" and writes the following lines to it,
    // or appends them to the existing "log.txt" file:

    // Log Entry : <current long time string> <current long date string>
    //  :
    //  :Test1
    // -------------------------------

    // Log Entry : <current long time string> <current long date string>
    //  :
    //  :Test2
    // -------------------------------

    // It then writes the contents of "log.txt" to the console.

}
