using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_ArithmeticOperator
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

            /** 변수 선언과 초기화 */
            int intResult = 0;
            int intA = 100;
            int intB = 50;

            /** 덧셈 */
            intResult = intA + intB;
            Console.WriteLine("덧셈 : " + intResult);

            /** 뺄셈 */
            intResult = intA - intB;
            Console.WriteLine("뺄셈 : " + intResult);

            /** 곱셈 */
            intResult = intA * intB;
            Console.WriteLine("곱셈 : " + intResult);

            /** 나눗셈 */
            intResult = intA / intB;
            Console.WriteLine("나눗셈 : " + intResult);

            /** 나머지 */
            intResult = intA % intB;
            Console.WriteLine("나머지 : " + intResult);

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
