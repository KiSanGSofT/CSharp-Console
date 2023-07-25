using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zTestConsoleApp
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

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
