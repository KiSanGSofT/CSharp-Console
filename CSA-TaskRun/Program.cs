using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSA_TaskRun
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

            Action<object> action = (object obj) =>
            {
                Console.WriteLine($"Task 정보 = {Task.CurrentId}, obj={obj}, Thread={Thread.CurrentThread.ManagedThreadId} {Environment.NewLine}");
            };

            /** Task 생성 */
            Task t1 = new Task(action, "김치");

            Console.WriteLine($"1번 Task 생성, 초기화 {Environment.NewLine}");
            Thread.Sleep(500);

            /** Task 생성과 시작 */
            Task t2 = Task.Factory.StartNew(action, "감자");

            Console.WriteLine($"2번 Task 생성, 초기화, 시작 {Environment.NewLine}");
            Thread.Sleep(500);

            /** Task 작업이 끝날 때까지 대기 */
            t2.Wait();

            Console.WriteLine($"2번 Task 작업완료까지 대기 {Environment.NewLine}");
            Thread.Sleep(500);

            /** Task 시작 */
            t1.Start();

            Console.WriteLine($"1번 Task 시작. (Main Thread={Thread.CurrentThread.ManagedThreadId}) {Environment.NewLine}");
            Thread.Sleep(500);

            /** Task 작업이 끝날 때까지 대기 */
            t1.Wait();

            Console.WriteLine($"1번 Task 작업완료까지 대기 {Environment.NewLine}");
            Thread.Sleep(500);

            /** Task 생성과 시작 */
            String taskData = "고구마";
            Task t3 = Task.Run(() =>
            {
                Console.WriteLine($"Task={Task.CurrentId}, obj={taskData}, Thread={Thread.CurrentThread.ManagedThreadId} {Environment.NewLine}");
            });

            Console.WriteLine($"3번 Task 생성, 초기화, 시작 {Environment.NewLine}");
            Thread.Sleep(500);

            /** Task 작업이 끝날 때까지 대기 */
            t3.Wait();

            Console.WriteLine($"3번 Task 작업완료까지 대기 {Environment.NewLine}");
            Thread.Sleep(500);

            /** Task 생성 */
            Task t4 = new Task(action, "상추");

            Console.WriteLine($"4번 Task 생성, 초기화 {Environment.NewLine}");
            Thread.Sleep(500);

            /** Task 동기적 실행 */
            t4.RunSynchronously();

            Console.WriteLine($"4번 Task 동기적 실행 {Environment.NewLine}");
            Thread.Sleep(500);

            /** Task 작업이 끝날 때까지 대기 */
            t4.Wait();

            Console.WriteLine($"4번 Task 작업완료까지 대기 {Environment.NewLine}");
            Thread.Sleep(500);

            //----------

            Console.WriteLine("\n----- 종료 / Press Any Key -----\n");

            Console.ReadKey();
        }
    }
}
