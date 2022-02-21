using System;
using System.Collections.Generic;
using System.Text;

namespace Snakev2
{
    class Fruit
    {
       static Random Rnd = new Random();
        public Position CurrentPos { get; set; } = new Position(Rnd.Next(2, 25), Rnd.Next(2, 25));

        public Fruit()
        {
            GenerateFruit();
        }

        public void GenerateFruit()
        {
            Console.SetCursorPosition(CurrentPos.X, CurrentPos.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("■");

        }


    }
}
