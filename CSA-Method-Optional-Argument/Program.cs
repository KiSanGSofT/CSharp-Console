using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * --------------------------------------------------
 * 작성일 : 2023-07-26
 * 작성자 : 기상소프트 / kisangsoft@naver
 * 제목: 메서드의 Optional Arguments 의 사용
 * --------------------------------------------------
 * 1. 메서드의 Argument 에 Parameter 값이 전달되지 않는 경우
 *   Argument 에서 설정한 기본값을 출력한다.
 * 2. 메서드의 Argument 에 Parameter 값이 전달되는 경우
 *   Argument 에 전달된 Parameter 값을 출력한다.
 * --------------------------------------------------
 */
namespace CSA_Method_Optional_Argument
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

            // 메서드에 입력파라미터가 없는 경우
            mtdPrintText();

            Console.WriteLine();

            // 메서드에 입력파라미터가 있는 경우
            mtdPrintText("메서드의 Argument 에 Parameter 를 전달합니다.");

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }

        /// <summary>
        /// 입력 Argument 에 전달된 Parameter 가 없는 경우 
        /// 정해진 기본 문자열을 출력한다.
        /// </summary>
        /// <param name="text"></param>
        private static void mtdPrintText(string text = "메서드의 Argument 에 전달받은 Parameter 가 없습니다.")
        {
            Console.WriteLine(text);
        }
    }
}
