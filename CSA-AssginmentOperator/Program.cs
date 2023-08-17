using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_AssginmentOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / 할당 연산자 -----\n");
            Console.ReadKey();

            //----------

            // 변수의 선언과 값 설정
            int varInt = 10;
            string varStr = "10";
            bool varBool = true;

            Console.WriteLine(varInt);
            Console.WriteLine(varStr);
            Console.WriteLine(varBool);

            Console.WriteLine("\r");

            // 변수의 값 재설정
            varInt = 100;
            varStr = "100";
            varBool = false;

            Console.WriteLine(varInt);
            Console.WriteLine(varStr);
            Console.WriteLine(varBool);

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");
            Console.ReadKey();
        }
    }
}
