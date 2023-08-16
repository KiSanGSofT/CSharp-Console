using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / 삼항연산자 -----\n");

            //----------

            int varInt_1 = 10;
            int varInt_2 = 50;

            bool varResult = false;
            int intResult = 0;

            varResult = (varInt_1 > varInt_2) ? true : false;
            Console.WriteLine(varResult);

            intResult = (varInt_1 > varInt_2) ? varInt_1 : varInt_2;
            Console.WriteLine(intResult);

            Console.WriteLine("\r");

            varResult = (varInt_1 < varInt_2) ? true : false;
            Console.WriteLine(varResult);

            intResult = (varInt_1 < varInt_2) ? varInt_1 : varInt_2;
            Console.WriteLine(intResult);

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
