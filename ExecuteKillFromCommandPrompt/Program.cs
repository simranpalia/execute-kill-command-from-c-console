using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteKillFromCommandPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> processesToKill = new List<string>();

            processesToKill.Add("notepad");
            processesToKill.Add("notepad++");

            var processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (processesToKill.Any(x => x == item.ProcessName))
                {
                    Console.WriteLine("Killing... " + item.ProcessName);
                    item.Kill();
                }
            }
            Console.ReadKey();
        }
    }
}
