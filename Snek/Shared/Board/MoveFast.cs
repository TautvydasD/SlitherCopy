using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class MoveFast : IMovement
    {
        public int Speed { get; set; } = 100;
        public MoveFast()
        {

        }

        public int Move()
        {
            return Speed;
        }
    }
}
