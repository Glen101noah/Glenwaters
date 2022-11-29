using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glenwatersutil
{
    public static class logger
    {

        public static void WriteLog(string message) {

            string logPath = ConfigurationManager.AppSettings["logpath"];

            using(StreamWriter writer = new StreamWriter(logPath, true)) {

                writer.WriteLine($"{DateTime.Now} : {message}");
            
            
            
            }
        
        
        }

    }
}
