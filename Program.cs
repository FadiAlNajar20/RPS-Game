namespace RPS_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            try
            {
                RPSGame game = new RPSGame(name);
                game.PlayGame();
            }
            catch(Exception e)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("\nThanks for playing!");
            }
                
        }
    }
}
