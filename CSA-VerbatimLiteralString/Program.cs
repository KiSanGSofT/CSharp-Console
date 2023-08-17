using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_VerbatimLiteralString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / 리터럴 문자열 -----\n");
            Console.ReadKey();

            //----------

            string txtString = String.Empty;
            string txtVerbatimLiteral = String.Empty;

            txtString = "E:\\CSharp\\Chsarp_Basic\\CSharp_Basic\\CSharp_Basic.sln";
            txtVerbatimLiteral = @"E:\CSharp\Chsarp_Basic\CSharp_Basic\CSharp_Basic.sln";

            Console.WriteLine(txtString);
            Console.WriteLine(txtVerbatimLiteral);

            Console.WriteLine("\n");

            txtString = "그가 말하길 이번에 마지막 \"\uae30\ud68c\"라고 말했다.";
            txtVerbatimLiteral = @"그가 말하길 이번에 마지막 ""\uae30\ud68c""라고 말했다.";

            Console.WriteLine(txtString);
            Console.WriteLine(txtVerbatimLiteral);

            Console.WriteLine("\n");

            string[] @station = { "서울역", "대전역", "\ub300\uad6c\uc5ed", "부산역" };
            for (int lpIdx = 0; lpIdx < @station.Length; lpIdx++)
            {
                Console.WriteLine($"여기는 {@station[lpIdx]} 입니다.");
            }

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");
            Console.ReadKey();
        }
    }
}
