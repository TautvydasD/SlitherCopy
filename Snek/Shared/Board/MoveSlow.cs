using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class MoveSlow : IMovement
    {
        public int Speed { get; set; } = 300;
        public MoveSlow()
        {

        }

        public int Move()
        {
            return Speed;
        }
    }
}
