using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClass.Interfaces;

namespace GameClass.Players
{
    class UberCheaterPlayer : Player, IGame
    {
        private static int number = 39;

        public UberCheaterPlayer(string name) : base(name, "Убер-читер")
        {

        }

        public int Play()
        {
            bool flag = true;

            do
            {
                number++;

                if (Game._regularPlayerStats.Count == 0)
                {
                    break;
                }

                foreach (int cheatNumber in Game._regularPlayerStats)
                {
                    if (cheatNumber == number)
                    {
                        flag = true;
                        break;
                    }

                    flag = false;
                }

                if (Game._notePlayerStats.Count == 0)
                {
                    break;
                }

                foreach (int cheatNumber in Game._notePlayerStats)
                {
                    if (cheatNumber == number)
                    {
                        flag = true;
                        break;
                    }

                    flag = false;
                }

                if (Game._uberPlayerStats.Count == 0)
                {
                    break;
                }

                foreach (int cheatNumber in Game._uberPlayerStats)
                {
                    if (cheatNumber == number)
                    {
                        flag = true;
                        break;
                    }

                    flag = false;
                }

                if (Game._cheaterPlayerStats.Count == 0)
                {
                    break;
                }

                foreach (int cheatNumber in Game._uberCheaterPlayerStats)
                {
                    if (cheatNumber == number)
                    {
                        flag = true;
                        break;
                    }

                    flag = false;
                }

            } while (flag);


            return number;
        }
    }
}
