using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Randoming : Player
    {
        public Randoming() { }

        public Randoming(string n) : base(n)
        {
        }

        public override Roshambo GetRoshambo()
        {
            Random generating = new Random();
            return (Roshambo)generating.Next(3);
        }
    }
}
