using System;
using System.Collections.Generic;
using System.Text;

namespace Snakev2
{
    public class Board
    {
        public static int width = 50;
        public static int heigth = 25;
        public static int score;
        public void Generate()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 2; i < width; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for (int i = 2; i < width; i++)
            {
                Console.SetCursorPosition(i, heigth);
                Console.Write("-");
            }
            for (int i = 2; i < heigth; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("|");
            }
            for (int i = 2; i < heigth; i++)
            {
                Console.SetCursorPosition(width, i);
                Console.WriteLine("|");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void DrawScore()
        {
            Console.SetCursorPosition(15, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Score:{score}");
        }
    }
}