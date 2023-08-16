using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_TodayCurrentTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / 오늘의 현재날짜 -----\n");
            Console.ReadKey();

            //----------
            String tmpTxt = String.Empty;

            DateTime varNow = DateTime.Now;
            Console.WriteLine($"오늘의 현재 날짜와 시간 : {varNow}");

            tmpTxt = varNow.ToString("yyyy MM dd");
            Console.WriteLine($"현재 날짜 : {tmpTxt}");

            tmpTxt = varNow.ToString("hh mm ss");
            Console.WriteLine($"현재 시간 : {tmpTxt}");

            Console.WriteLine();

            tmpTxt = varNow.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");
            Console.WriteLine($"현재 날짜 : {tmpTxt}");

            tmpTxt = varNow.ToString("yyyy년 MM월 dd일 hh:mm:ss");
            Console.WriteLine($"현재 날짜 : {tmpTxt}");

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");
            Console.ReadKey();
        }
    }
}
