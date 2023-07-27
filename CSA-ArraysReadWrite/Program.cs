using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_ArraysReadWrite
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

            /** 배열 선언 및 초기화 */
            string[] arrayObject = { "C", "C++", "C#", "ASP.NET", "MVC5" };

            var varDataType = arrayObject.GetType();
            var varLength = arrayObject.Length;

            /** 배열 정보 */
            Console.WriteLine("배열의 데이터타입 : " + varDataType);
            Console.WriteLine("배열의 길이 : " + varLength);

            Console.WriteLine("\r");

            /** 반복문으로 배열 요소 읽기 */
            var varIndexOfArray = 0;
            foreach (string lpTxt in arrayObject)
            {
                varIndexOfArray = Array.IndexOf(arrayObject, lpTxt);
                Console.WriteLine("배열 " + varIndexOfArray + " 번째 값 - array[" + varIndexOfArray + "] : " + lpTxt);
            }
            Console.WriteLine("\r");

            /** 반복문으로 배열 요소 읽기 */
            Console.WriteLine("array[0] : " + arrayObject[0]);
            Console.WriteLine("array[1] : " + arrayObject[1]);

            /** 반복문으로 배열 요소 쓰기 */
            arrayObject[2] = "WINFORM";
            Console.WriteLine("array[2] : " + arrayObject[2]);

            arrayObject[3] = "WPF";
            Console.WriteLine("array[3] : " + arrayObject[3]);

            arrayObject[4] = "UWP";
            Console.WriteLine("array[4] : " + arrayObject[4]);

            /*
            Console.WriteLine("\r");

            /* * 배열 재설정 * /
            arrayObject = new string[] { "C", "C++", "C#", "ASP.NET", "MVC5", "WinForm", "WPF", "UWP" };

            /** 반복문으로 배열 요소 읽기 * /
            foreach (string lpTxt in arrayObject)
            {
                varIndexOfArray = Array.IndexOf(arrayObject, lpTxt);
                Console.WriteLine("배열 " + varIndexOfArray + " 번째 값 - array[" + varIndexOfArray + "] : " + lpTxt);
            }
            */

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
