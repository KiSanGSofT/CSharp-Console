using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_Process_Memory_Usage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;

            Console.WriteLine("\n----- 시작 / Press Any Key -----\n");
            Console.ReadKey();

            //----------

            Process currentProcess = Process.GetCurrentProcess();
            double memoryUsage = currentProcess.WorkingSet64 / (1024.0 * 1024.0);
            Console.WriteLine($"현재 메모리 사용량: {memoryUsage:F2} MB");

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
