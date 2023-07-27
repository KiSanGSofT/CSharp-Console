using System;
using System.Threading;
using System.Windows.Forms;

namespace CSA_MacroBasic
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

            Thread.Sleep(5000);

            Thread t = new Thread(() =>
            {
                while (true)
                {
                    SendKeys.SendWait("매크로 문자열 입력{Enter}");
                    Thread.Sleep(1000);
                    /*
                    if (Keyboard.IsKeyDown(Key.Right))
                    {
                        SendKeys.SendWait(" \n 매크로 문자열 입력");
                        // SendKeys.Send("^c"); // 단축키
                        // SendKeys.Send("{Enter}"); // 특수키
                    }
                    */
                }
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
