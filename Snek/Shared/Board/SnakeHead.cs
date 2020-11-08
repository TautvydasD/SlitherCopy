using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class SnakeHead
    {
        public Coordinates pos { get; set; }
        public SnakeHead()
        {

        }

        public SnakeHead(int x, int y)
        {
            pos = new Coordinates(x, y);
        }
    }
}
