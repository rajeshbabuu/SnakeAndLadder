namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome to the Snake and Ladder Program------- ");

            SnakeGame SnakeGame1 = new SnakeGame();

            //  day4ProblemObj.singlePlayer();

            //  day4ProblemObj.firstDiceRoll();
            SnakeGame1.snakeAndLadder();
        }
    }
}