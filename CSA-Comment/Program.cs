using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_Comment
{
    /// <summary>
    /// Program 클래스입니다.
    /// 프로그램의 시작부분입니다.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;

            Console.WriteLine("\n----- 시작 / Press Any Key -----\n");
            Console.ReadKey();

            //----------

            // 한줄 주석
            Console.WriteLine(" // 은 한줄 주석입니다.");

            /* 여러 줄 주석 */
            Console.WriteLine(" /* ~ */ 은 여러줄 주석입니다.");

            /** 사용자함수를 호출합니다. */
            PrintComment();

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }

        /// <summary>
        /// 함수 주석 부분입니다.
        /// </summary>
        private static void PrintComment()
        {
            Console.WriteLine("/// <summary> ~ /// </summary> 은 클래스, 함수 ( 메서드 ) 에 사용되는 주석입니다.");
        }
    }
}
