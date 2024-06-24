using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public class RPSGame
    {
        public Player player;
        public Player computer;
        private Random random;

        public RPSGame(string name)
        {
            player = new Player(name);
            computer = new Player("AI");
            random = new Random();
        }

        public void PlayGame()
        {
            while (player.Score < 3 && computer.Score < 3)
            {
                PlayRound();
            }
            Console.WriteLine($"\nFinal Score - {player.Name}: {player.Score}, Computer: {computer.Score}");
            if (player.Score == 3)
            {
                Console.WriteLine("You won the game!");
            } else if(computer.Score == 3)
            {
                Console.WriteLine("AI won the game!");
            }
            else
            {
                Console.WriteLine("The game is a draw!");
            }  
        }

        private void PlayRound()
        {
            string playerMove = player.Choose();
            string computerMove = GetComputerMove();

            Console.Write($"{player.Name}: {playerMove}, ");
            Console.WriteLine($"AI: {computerMove}");

            DetermineWinner(playerMove, computerMove);

            Console.WriteLine($"Score - {player.Name}: {player.Score}, AI: {computer.Score}");
        }

        private string GetComputerMove()
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    return "ROCK";
                case 2:
                    return "PAPER";
                case 3:
                    return "SCISSORS";
                default:
                    return "";
            }
        }

        public void DetermineWinner(string playerMove, string computerMove)
        {
            if (playerMove == computerMove)
            {
                Console.WriteLine("It's a draw!");
            }
            else if ((playerMove == "ROCK" && computerMove == "SCISSORS") ||
                     (playerMove == "PAPER" && computerMove == "ROCK") ||
                     (playerMove == "SCISSORS" && computerMove == "PAPER"))
            {
                Console.WriteLine("You win this round!");
                player.Score++;
            }
            else
            {
                Console.WriteLine("AI wins this round!");
                computer.Score++;
            }
        }

    }
}
