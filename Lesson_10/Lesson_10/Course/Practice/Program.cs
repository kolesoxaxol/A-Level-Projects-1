using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] intArray = new int[100];

            int rndNumber;

            for(int i=0; i < 100; i++)
            {
                rndNumber = rnd.Next(1, 100);
                intArray[i] = rndNumber;
                Console.Write(rndNumber+",");
            }

            int positive;
            int negative;

            int krt = ProcessingNumber(intArray, out positive, out negative);

            Console.WriteLine("");
            Console.WriteLine($"Чётные: {positive}, Не чётные: {negative}, кратные 10: {krt}");
            Console.ReadKey();
        }

        public static int ProcessingNumber(int[] intArray, out int positive, out int negative)
        {
            positive = 0;
            negative = 0;
            int krt = 0;

            foreach (int num in intArray)
            {
                if (num % 2 == 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }

            foreach(int num in intArray)
            {
                if (num % 10 == 0)
                {
                    krt++;
                }
            }      

            return krt;
        }
    }
}
