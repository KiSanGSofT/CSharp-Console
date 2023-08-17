using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / 변수 -----\n");
            Console.ReadKey();

            //----------

            int varInt = 10;

            // int 데이터를 화면에 출력한다.
            Console.WriteLine(varInt);

            double varDouble = 10.01;

            // double 데이터를 화면에 출력한다.
            Console.WriteLine(varDouble);

            char varChar = 'A';

            // char 데이터를 화면에 출력한다.
            Console.WriteLine(varChar);

            string varString = "alphabet A";

            // string 데이터를 화면에 출력한다.
            Console.WriteLine(varString);

            bool varBool = true;

            // bool 데이터를 화면에 출력한다.
            Console.WriteLine(varBool);

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");
            Console.ReadKey();
        }
    }
}
