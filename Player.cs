using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    abstract class Player
    {
        public string Name { get; set; }

        public Roshambo Guess { get; set; }

        public Player() { }

        public Player(string Nm)
        {
            Name = Nm;
        }
        public abstract Roshambo GetRoshambo();
    }
}
