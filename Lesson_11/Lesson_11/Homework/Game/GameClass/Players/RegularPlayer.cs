using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClass.Interfaces;

namespace GameClass.Players
{

    
    public class RegularPlayer : Player,  IGame
    {

        Random rnd = new Random();

       public RegularPlayer(string name):base(name, "Обычный")
       {
           
       }

        public int Play()
        {
            return rnd.Next(40, 140);
        }
    }
}
