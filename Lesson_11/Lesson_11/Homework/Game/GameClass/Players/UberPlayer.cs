using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClass.Interfaces;

namespace GameClass.Players
{
    
    class UberPlayer : Player,  IGame
    {

        private static int number = 39;

        public UberPlayer(string name) : base(name, "Убер-игрок")
        {

        }

        public int Play()
        {
            number++;
            return number;
        }
    }
}
