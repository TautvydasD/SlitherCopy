using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class SnakeBody
    {
        public List<Coordinates> posList { get; set; } 

        //public SnakeBody()
        //{

        //}

        public SnakeBody()
        {
            posList = new List<Coordinates>();
        }

        public void Add(int x, int y)
        {
            posList.Add(new Coordinates(x, y));
        }

    }
}
