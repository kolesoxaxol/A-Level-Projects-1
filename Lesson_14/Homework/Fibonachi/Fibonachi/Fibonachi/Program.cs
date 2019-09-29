using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MainThread Started: {0}", Thread.CurrentThread.ManagedThreadId);

            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Task Async [Fibonachi]");
            Task<int> task = FibonachiAsync(n);

            Console.WriteLine("MainThread Continue with delay 5 seconds: {0}", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(5000);

            Console.WriteLine("Trying To Get Fibonachi Async Result");

            if (!task.Wait(10000))
            {
                Console.WriteLine("Sorry \"NO RESULT\" calculation is so long");
            }
            else
            {
                Console.WriteLine($"Fibonachi Result: {task.Result.ToString()}");
            }

            Console.ReadKey();
        }

        public static async Task<int> FibonachiAsync(int n)
        {
            int value = await Task.Run(() =>
            {
                Console.WriteLine("Fibonachi Async Started: {0}", Thread.CurrentThread.ManagedThreadId);
                return FibonachiRecursion(n);
            });

            Console.WriteLine("Fibonachi Async Completed: {0}", Thread.CurrentThread.ManagedThreadId);

            return value;
        }

        public static int FibonachiRecursion(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonachiRecursion(n - 1) + FibonachiRecursion(n - 2);
            }
        }
    }
}
