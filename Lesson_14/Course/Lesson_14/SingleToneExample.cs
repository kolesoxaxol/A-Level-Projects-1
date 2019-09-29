using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_14
{
    public class SingletonExample
    {
        private static SingletonExample _instance;
        private static object _syncObject = new object();

        private SingletonExample()
        {
            Thread.Sleep(500);
            Console.WriteLine($"Singleton Created! {DateTime.Now.Ticks}");
        }


        public static SingletonExample GetInstance
        {
            get
            {
                lock (_syncObject)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonExample();
                    }
                }

                return _instance;
            }
        }

        public async Task<int> Sum(int a, int b)
        {
            int sum = a + b;

            Console.WriteLine("Async Simulation Run");
            await AsyncSimulation(sum);
            Console.WriteLine("Async Simulation Completed");

            return a + b;
        }

        private async Task AsyncSimulation(int delay)
        {
            await Task.Run(() => { Thread.Sleep(delay * 1000); });
        }
    }
}
