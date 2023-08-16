using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / StringBuilder  -----\n");

            //----------

            StringBuilder sBuilder = new StringBuilder();
            sBuilder.Append("C# \n");
            sBuilder.Append("Java \n");
            sBuilder.Append("Python \n");
            sBuilder.Append("MySQL \n");
            sBuilder.Append("MSSQL \n");
            sBuilder.Append("Oracle \n");

            Console.WriteLine(sBuilder.ToString());

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
