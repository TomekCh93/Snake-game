using System;
using System.Collections.Generic;
using System.Text;

namespace Snakev2
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position()
        {
            X = Board.heigth / 3;
            Y = Board.width / 3;

        }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}