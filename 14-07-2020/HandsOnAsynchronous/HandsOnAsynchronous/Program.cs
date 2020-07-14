
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace HandsOnAsynchronous
{
    class Program
    {
       

        static async Task Main(string[] args)
        {
            var stopWatch = Stopwatch.StartNew();
            var addiTionTask1 = Add();
            var subTractTask2 = Sub();
            var mulTiplyTask3 = Mul();
            await Task.WhenAll(addiTionTask1, subTractTask2,mulTiplyTask3 );
            Console.WriteLine("Total time: " + stopWatch.Elapsed.Seconds + "Seconds");
            Console.ReadLine();

        }
        public static async Task Add()
        {
            
            Console.WriteLine("addition started at " + DateTime.Now);
            await Task.Delay(5000);
            int a = 5; int b = 6;
            int c = a + b;          
            Console.WriteLine("addition completed: {0} {1}" , c, DateTime.Now);
        }

        public static async Task Sub()
        {
            Console.WriteLine("subtraction started at " + DateTime.Now);          
            await Task.Delay(1000);
            int a = 6; int b = 5;
            int c = a - b;
            Console.WriteLine("subtraction completed: {0} {1}" ,c, DateTime.Now);
        }
        public static async Task Mul()
        {

            Console.WriteLine("Multiplication started at " + DateTime.Now);
            await Task.Delay(2000);
            int a = 5; int b = 6;
            int c = a * b;
            Console.WriteLine("multiplication completed:{0} {1} " , c, DateTime.Now);
        }
    }
}
