using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Human : Player
    {
        public Human(string name) : base(name)
        {
        }
        public override Roshambo GetRoshambo()
        {
            Console.WriteLine("please select  1.paper 2.rock 3.scissors? ");
            string input = Console.ReadLine().ToLower();

            if (input == "paper")
            {
                return Roshambo.paper;
            }
            else if (input == "rock")
            {
                return Roshambo.rock;
            }
            else if (input == "scissors")
            {
                return Roshambo.scissors;
            }
            else
            {
                Console.Write("Invalid input. ");
                return GetRoshambo();
            }
        }
    }
}
