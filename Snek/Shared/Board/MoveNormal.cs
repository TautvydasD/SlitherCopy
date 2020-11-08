using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class MoveNormal : IMovement
    {
        public int Speed { get; set; } = 200;
        public MoveNormal()
        {

        }

        public int Move()
        {
            return Speed;
        }
    }
}
