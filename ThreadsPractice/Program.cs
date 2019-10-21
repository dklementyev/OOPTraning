using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(ThreadFunction1);
            var thread2 = new Thread(ThreadFunction2);
            thread1.Start();
            thread2.Start();

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main Thread talks: {i}");
                Thread.Sleep(100);
            }

            Console.Read();
        }



        public static void ThreadFunction1()
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread1 talks: {i}");
                Thread.Sleep(100);
            }
        }
        public static void ThreadFunction2()
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread2 talks: {i}");
                Thread.Sleep(100);
            }
        }


    }
}
