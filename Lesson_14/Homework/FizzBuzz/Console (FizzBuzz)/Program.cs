using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DefineMultipleClass;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            long[] fizzbuzzArray;
            long[] subbArrayA;
            long[] subbArrayB;

            long arraySize = 0;
            long subArrayA_Size = 0;
            long subArrayB_Size = 0;

            int s = 0;

            string arraySizeStr;

            while (flag)
            { 
                Console.Write("Size of Array: ");
                arraySizeStr = Console.ReadLine();

                flag = !long.TryParse(arraySizeStr, out arraySize);

                if (arraySize < 1000)
                {
                    flag = true;
                }
            }

            // Fill Array
            fizzbuzzArray = new long[arraySize];
            int number = 1;

            for (int i = 0; i < fizzbuzzArray.Length; i++)
            {
                fizzbuzzArray[i] = number;
                number++;
            }

            // Devide Array
            if (fizzbuzzArray.Length % 2 != 0)
            {
                subArrayA_Size = fizzbuzzArray.Length / 2;
                subArrayB_Size = (fizzbuzzArray.Length + 1) / 2;
            }
            else
            {
                subArrayA_Size = fizzbuzzArray.Length / 2;
                subArrayB_Size = subArrayA_Size;
            }

            subbArrayA = new long[subArrayA_Size];
            subbArrayB = new long[subArrayB_Size];

            for (int i = 0; i < subArrayA_Size; i++)
            {
                subbArrayA[s] = fizzbuzzArray[s];
                s++;
            }

            s = 0;
            for (; subArrayA_Size < fizzbuzzArray.Length; subArrayA_Size++)
            {
                subbArrayB[s] = fizzbuzzArray[subArrayA_Size];
                s++;
            }

            /* --- Async Starter ---*/

            // Initialize Timer Async
            Stopwatch watch_async = new Stopwatch();

            // Timer Start
            watch_async.Start();

            DefineMultiple thread_2 = new DefineMultiple();
            var result_2 = thread_2.GetFizzBuzzAsync(subbArrayA);

            DefineMultiple thread_1 = new DefineMultiple();
            Dictionary<long, string> dict_1 = thread_1.GetFizzBuzz(subbArrayB);

            // Get Task Async Result
            Dictionary<long, string> dict_2 = result_2.Result;

            // Timer Stop
            watch_async.Stop();

            // Get Elapsed Time
            Console.WriteLine($"Time Elapsed {watch_async.Elapsed.ToString()}");

            Console.WriteLine("");

            // Initialize Timer Async
            Stopwatch watch = new Stopwatch();

            /* --- No Async Starter ---*/

            // Timer Start
            watch.Start();
            DefineMultiple thread_1_noasync = new DefineMultiple();

            Dictionary<long, string> result = thread_1.GetFizzBuzz(fizzbuzzArray);

            // Timer Stop
            watch.Stop();

            // Get Elapsed Time
            Console.WriteLine($"Time Elapsed {watch.Elapsed.ToString()}");

            Console.Write("Press any key to Exit...");
            Console.ReadKey();
        }
    }
}
