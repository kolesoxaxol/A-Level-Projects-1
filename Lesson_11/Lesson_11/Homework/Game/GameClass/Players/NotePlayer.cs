using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClass.Interfaces;

namespace GameClass.Players
{
    class NotePlayer : Player, IGame
    {
        private static List<int> numbers = new List<int>();

        Random rnd = new Random();

        public NotePlayer(string name) : base(name, "Игрок-блокнот")
        {
            
        }

        public int Play()
        {
            int number;
            bool flag = true;

            do
            {
                number = rnd.Next(40, 140);

                if (numbers.Count == 0)
                {
                    break;
                }

                foreach (int notedNumber in numbers)
                {
                    if (notedNumber == number)
                    {
                        flag = true;
                        break;
                    }

                    flag = false;
                }

            } while (flag);

            numbers.Add(number);
            return number;
        }
    }
}
