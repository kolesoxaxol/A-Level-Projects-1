using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch watch = new Stopwatch();

            watch.Start();

            Console.WriteLine("Start");
            Console.WriteLine(Environment.NewLine);

            Task.Run(() =>
            {
                Thread.Sleep(500);
                var singleton2 = SingletonExample.GetInstance;
                singleton2.Sum(2, 2);
            });

            var singleton = SingletonExample.GetInstance;
            var c = singleton.Sum(2, 2);

            Console.WriteLine("Async simulation launched");

            Console.WriteLine(c.Result);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(watch.Elapsed.ToString());

            Console.ReadKey();
        }
    }
}
