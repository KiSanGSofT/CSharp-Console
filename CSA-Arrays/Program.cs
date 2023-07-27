using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_Arrays
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

            Console.WriteLine("데이터 타입 : " + varDataType);
            Console.WriteLine("배열 크기 : " + varLength);

            Console.WriteLine("\r");

            /** 반복문 for 사용 배열 출력 */
            Console.WriteLine("---- 반복문 for 사용 배열 출력");
            for (int lpIdx = 0; lpIdx < arrayObject.Length; lpIdx++)
            {
                Console.WriteLine("배열 " + lpIdx + " 번째 값 : " + arrayObject[lpIdx]);
            }

            Console.WriteLine("\r");

            /** 반복문 foreach 사용 배열 출력 */
            Console.WriteLine("---- 반복문 foreach 사용 배열 출력");
            int intIndexOfArray = 0;
            foreach (string lpTxt in arrayObject)
            {
                intIndexOfArray = Array.IndexOf(arrayObject, lpTxt);
                Console.WriteLine("배열 " + intIndexOfArray + " 번째 값 : " + lpTxt);
            }

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
