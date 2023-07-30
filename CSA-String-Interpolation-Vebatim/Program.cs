using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_String_Interpolation_Vebatim
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

            string temp = @"멀
                            티
                            라
                            인";

            Console.WriteLine(temp);

            Console.WriteLine($"{temp}, 여러줄을 표현한다.");

            Console.WriteLine($@"{temp}, 
여러줄을 표현한다.");

            Console.ReadKey();

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();

        }
    }
}
