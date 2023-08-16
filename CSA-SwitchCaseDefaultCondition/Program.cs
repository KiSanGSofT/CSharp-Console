using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_SwitchCaseDefaultCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / StringBuilder  -----\n");
            Console.ReadKey();

            //----------

            /** 변수 선언 및 초기화 */
            int intExpCode = 3001;

            /** 조건선택 */
            switch (intExpCode)
            {
                case 1001:
                    Console.WriteLine("선택된 값 : " + intExpCode);
                    break;
                case 2001:
                    Console.WriteLine("선택된 값 : " + intExpCode);
                    break;
                case 3001:
                    Console.WriteLine("선택된 값 : " + intExpCode);
                    break;
                default:
                    Console.WriteLine("선택된 값이 없습니다.");
                    break;
            }

            Console.WriteLine();

            /** 변수 선언 및 초기화 */
            string stringExpCode = "KIA";

            /** 조건선택 */
            switch (stringExpCode)
            {
                case "HD": Console.WriteLine("현대차 선택"); break;
                case "KIA": Console.WriteLine("기아차 선택"); break;
                case "SYG": Console.WriteLine("쌍용차 선택"); break;
                default: Console.WriteLine("선택된 값이 없음"); break;
            }

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
