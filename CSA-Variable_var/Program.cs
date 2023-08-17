using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_Variable_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / 변수 var -----\n");
            Console.ReadKey();

            //----------

            char varChar;
            string varString;
            int varNumber;
            bool varBool;

            var impChar = 'A';
            var impString = "가나다";
            var impNumber = 1234;
            var impBool = true;
            Object variable = null;

            Console.WriteLine($"{impChar} :  {impChar.GetType()}");
            Console.WriteLine($"{impString} :  {impString.GetType()}");
            Console.WriteLine($"{impNumber} :  {impNumber.GetType()}");
            Console.WriteLine($"{impBool} :  {impBool.GetType()}");

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");
            Console.ReadKey();
        }
    }
}
