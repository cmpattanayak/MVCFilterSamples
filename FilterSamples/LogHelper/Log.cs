using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FilterSamples.LogHelper
{
    public static class Log
    {
        public static void LogMessage(string message)
        {
            using (StreamWriter sw = File.AppendText(@"D:\GIT\FilterSamples\FilterSamples\Logs\FilterLog.txt"))
            {
                sw.Write("\r\nLog Entry: ");
                sw.WriteLine("{0} - {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
                sw.WriteLine("{0}", message);
                sw.WriteLine("-------------------------------");
            }
        }
    }
}