using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class RockGuy : Player
    {
        public RockGuy(string name) : base(name)
        {
        }

        public override Roshambo GetRoshambo()
        {
            return Roshambo.rock;
        }
    }
}