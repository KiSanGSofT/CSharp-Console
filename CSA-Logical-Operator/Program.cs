using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_Logical_Operator
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

            int intA = 10;
            int intB = 50;
            int intC = 100;
            bool boolResult = false;

            boolResult = ((intA < intB) && (intB < intC));
            Console.WriteLine("&& : " + boolResult);

            boolResult = ((intA > intB) && (intB < intC));
            Console.WriteLine("&& : " + boolResult);

            boolResult = ((intA < intB) || (intB > intC));
            Console.WriteLine("|| : " + boolResult);

            boolResult = ((intA > intB) || (intB > intC));
            Console.WriteLine("|| : " + boolResult);

            boolResult = (!(intA == intC));
            Console.WriteLine("! : " + boolResult);

            boolResult = (!(intA < intC));
            Console.WriteLine("! : " + boolResult);

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
