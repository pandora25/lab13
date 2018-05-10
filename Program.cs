using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public enum Roshambo { rock, scissors, paper }

    class Program
    {
        static void Main(string[] args)
        {
            List<Player> Numbering = new List<Player>();

            Numbering.Add(new Randoming("Google"));
            Numbering.Add(new RockGuy("Rocky"));
            Human me = new Human("Mike");

            Console.WriteLine("Who do you want to play against?");
            for (int i = 0; i < Numbering.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Numbering[i].Name}");
            }
            int index = int.Parse(Console.ReadLine()) - 1;

            Numbering[index].Guess = Numbering[index].GetRoshambo();
            me.Guess = me.GetRoshambo();

            Console.WriteLine($"You: {me.Guess}\nThem: {Numbering[index].Guess}");
        }
    }
}
