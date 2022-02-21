using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Snakev2
{
    public class Snake
    {

        int Length = 3;
        public EnumDir direction { get; set; } = EnumDir.Right;
        public Position snakeHeadPos { get; set; } = new Position();
        List<Position> snakePositions = new List<Position>();
        public bool gameOver = false;
        public string endInfo = null;




        public void EatMeal()
        {
            Length++;
            Board.score += 100;

        }

        public void Move()
        {

            switch (direction)
            {
                case EnumDir.Left:
                    snakeHeadPos.X--;
                    break;
                case EnumDir.Right:
                    snakeHeadPos.X++;
                    break;
                case EnumDir.Up:
                    snakeHeadPos.Y--;
                    break;
                case EnumDir.Down:
                    snakeHeadPos.Y++;
                    break;
                default:
                    break;
            }

            Console.SetCursorPosition(snakeHeadPos.X, snakeHeadPos.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("■");

            snakePositions.Add(new Position(snakeHeadPos.X, snakeHeadPos.Y));
            if (snakePositions.Count > Length)
            {

                Position FirstPosition = snakePositions.First();
                Console.SetCursorPosition(FirstPosition.X, FirstPosition.Y);
                Console.Write(" ");
                snakePositions.Remove(FirstPosition);
            }
            CheckIfLose();
        }

        public void CheckIfLose()
        {
            int pointNum = 0;
            for (int i = 0; i < snakePositions.Count; i++)
            {

                if (snakeHeadPos.X == snakePositions[i].X && snakeHeadPos.Y == snakePositions[i].Y)
                {
                    pointNum++;

                }
                if (pointNum > 1)
                {
                    endInfo = "Snake hits his body.";
                    gameOver = true;
                }
            }

            if (snakeHeadPos.X > Board.width || snakeHeadPos.Y > Board.heigth - 1 || snakeHeadPos.Y < 2 || snakeHeadPos.X < 2)
            {
                endInfo = "Snake hits the wall.";

                gameOver = true;
            }


        }


    }

    public enum EnumDir
    {
        Up,
        Down,
        Right,
        Left
    }
}
