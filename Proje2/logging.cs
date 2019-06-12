using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Proje2
{
    class Log
    {


        static public void newlog(string stuff)
        {
            DateTime localDate = DateTime.Now;
            string path = @"Logs.log";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("L0GFILE");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(localDate.ToString() + stuff);
            }

        }

    }
}