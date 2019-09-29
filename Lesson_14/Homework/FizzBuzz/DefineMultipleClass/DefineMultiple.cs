using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DefineMultipleClass
{
    public class DefineMultiple
    {
        public Dictionary<long, string> GetFizzBuzz(long[] array)
        {
            Console.Write(new string('-', 5));
            Console.Write("Main Thread Started {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("");

            Dictionary<long, string> values = GetMultiple(array);

            Console.Write(new string('-', 5));
            Console.Write("Main Thread Completed {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("");

            return values;
        }

        public async Task<Dictionary<long, string>> GetFizzBuzzAsync(long[] array)
        {
            Dictionary<long, string> values = await Task.Run(() =>
            {
                Console.Write(new string('-', 25));
                Console.Write("Async Thread Started {0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("");
                return GetMultiple(array);
            });

            Console.Write(new string('-', 25));
            Console.Write("Async Thread Completed {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("");

            return values;
        }

        private Dictionary<long, string> GetMultiple(long[] array)
        {
            Dictionary<long, string> values = new Dictionary<long, string>();

            foreach (long number in array)
            {
                string result;

                if (number % 3 == 0 && number % 5 == 0)
                {
                    result = "FizzBuzz";
                }
                else if (number % 3 == 0)
                {
                    result = "Fizz";
                }
                else if (number % 5 == 0)
                {
                    result = "Buzz";
                }
                else
                {
                    result = "No multiple";
                }

                values.Add(number, result);
            }

            return values;
        }
    }
}