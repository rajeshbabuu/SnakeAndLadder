namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome to the Snake and Ladder Program------- ");

            SnakeGame SnakeGame1 = new SnakeGame();
            SnakeGame1.winningPosition();
        }
    }
}