using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_Combine_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / 변수 결합 -----\n");
            Console.ReadKey();

            //----------

            int varInt = 10;
            string varString = "10";

            Console.WriteLine("숫자변수 + 숫자변수 = " + (varInt + varInt));

            Console.WriteLine("숫자변수 + 문자열변수 = " + (varInt + varString));

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");
            Console.ReadKey();
        }
    }
}
