using System;
using System.Threading;

namespace Snakev2
{
    class Program
    {
        public static ConsoleKey userKey;
        public void GetKey(Snake snake)
        {
            if (Console.KeyAvailable)
            {
                userKey = Console.ReadKey().Key;
                switch (userKey)
                {
                    case ConsoleKey.UpArrow:
                        if (snake.direction == EnumDir.Down)
                        {
                            break;
                        }
                        snake.direction = EnumDir.Up;

                        break;
                    case ConsoleKey.DownArrow:
                        if (snake.direction == EnumDir.Up)
                        {
                            break;
                        }
                        snake.direction = EnumDir.Down;

                        break;
                    case ConsoleKey.LeftArrow:
                        if (snake.direction == EnumDir.Right)
                        {
                            break;
                        }
                        snake.direction = EnumDir.Left;

                        break;
                    case ConsoleKey.RightArrow:
                        if (snake.direction == EnumDir.Left)
                        {
                            break;
                        }
                        snake.direction = EnumDir.Right;

                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            var gameExit = false;
            do
            {
                Console.Clear();
                Console.CursorVisible = false;
                var fruit = new Fruit();
                var snake = new Snake();
                Board.score = 0;

                while (!snake.gameOver)
                {
                    var program = new Program();
                    var board = new Board();
                    board.Generate();
                    board.DrawScore();
                    program.GetKey(snake);
                    snake.Move();

                    if (snake.snakeHeadPos.X == fruit.CurrentPos.X && snake.snakeHeadPos.Y == fruit.CurrentPos.Y)
                    {
                        fruit = new Fruit();
                        snake.EatMeal();
                    }

                    Thread.Sleep(110);

                    if (snake.gameOver)
                    {
                        Console.Clear();
                        Console.WriteLine($"Game Over! {snake.endInfo} Your final score is: {Board.score}.\n");
                        Console.WriteLine("To play again press ENTER, to quit press any key.");
                        ConsoleKey inputKey = Console.ReadKey().Key;
                        if (inputKey != ConsoleKey.Enter)
                        {
                            gameExit = true;
                        }
                    }
                }
            } while (!gameExit);
        }
    }
}