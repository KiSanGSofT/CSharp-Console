using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSA_ThreadMulti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- 시작 / 생성자 Multi Thread -----\n");
            Console.ReadKey();

            //----------

            /** 스레드 생성 */
            Thread t1 = new Thread(new ThreadStart(DoThreadWork_1));
            Thread t2 = new Thread(new ThreadStart(DoThreadWork_2));

            Console.WriteLine("스레드 시작 !\n");

            /** 스레드 시작 */
            t1.Start();
            t2.Start();

            /** 스레드 종료 대기 */
            t1.Join();
            t2.Join();

            /** 스레드 시작 */
            Console.WriteLine("\n스레드 완료 !");

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }

        private static void DoThreadWork_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("작업 스레드 1 : " + i);
                Thread.Sleep(250);
            }
        }

        private static void DoThreadWork_2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("작업 스레드 2 : " + i);
                Thread.Sleep(500);
            }
        }
    }
}