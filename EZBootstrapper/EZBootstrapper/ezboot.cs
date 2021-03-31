using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace EZBootstrapper
{
    public class ezboot
    {      
        public string user = Environment.UserName;
        public string date = DateTime.Now.ToString("MMMM dd");
        public string time = DateTime.Now.ToString("HH:mm:ss");
        public string copyright = "ezboot";

        WebClient wc = new WebClient();

        public void Clear()
        {
            Console.Clear();
        }

        public void Title(string title)
        {
            Console.Title = title;           
        }

        public void rkey()
        {
            Console.ReadKey();
        }

        public void write(string label, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(label);
        }

        public void writeline(string label)
        {
            Console.WriteLine(label);
        }

        public void CheckExploit(string exploitname, string message)
        {
            bool flag = File.Exists(exploitname + ".exe");
            if (flag)
            {
                write(message, ConsoleColor.Red);
            }
            else
            { }           
        }

        public void Extract(string zipFileName, string outputDirectory)
        {
            Thread.Sleep(2000);
            ZipFile.ExtractToDirectory(zipFileName, outputDirectory);
        }
    }
}
