using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_MethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / 메서드 생성과 호출 -----\n");

            //----------

            DisplayConsole extClass = new DisplayConsole();
            extClass.Print("메서드를 호출합니다.");

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
