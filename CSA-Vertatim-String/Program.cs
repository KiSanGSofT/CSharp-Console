using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_Vertatim_String
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

            string vertatimText = @"있는 그대로
                        문자열 그대로
                        작성한 그대로
                        화면에 출력한다.
                        그래서 멀티라인도 가능하다.";

            Console.WriteLine(vertatimText);

            Console.WriteLine();

            vertatimText = vertatimText + @"
                다른 문자열을 추가할 때는
                @ 문자를 사용하고
                변수 또는 문자열을 덧붙이면 된다.
            ";

            Console.WriteLine(vertatimText);

            Console.ReadKey();

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
