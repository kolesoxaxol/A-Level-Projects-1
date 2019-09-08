using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClass
{
    public class Player
    {
        public string Name { get; private set; }
        public string Type { get; private set; }

        public Player(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
