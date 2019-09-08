using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GameClass.Interfaces;

namespace GameClass.Players
{
    public class CheaterPlayer : Player, IGame
    {
        Random rnd = new Random();

        public CheaterPlayer(string name) : base(name, "Игрок-читер")
        {

        }

        public int Play()
        {
            int number;
            bool flag = true;

            do
            {
                number = rnd.Next(40, 140);

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

                if (Game._uberCheaterPlayerStats.Count == 0)
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
