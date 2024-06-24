using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public string Choose()
        {
            string move = "";
            while (move != "ROCK" && move != "PAPER" && move != "SCISSORS")
            {
                Console.Write($"\n{Name}, enter ROCK, PAPER, or SCISSORS: ");
                move = Console.ReadLine().ToUpper();
            }
            return move;
        }
    }
}
