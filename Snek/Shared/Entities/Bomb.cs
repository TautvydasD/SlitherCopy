using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Board;

namespace Snek.Shared.Entities
{
    public class Bomb
    {
        public string Image = "doublePoints.png";
        public Bomb()
        {

        }
        public int Explode()
        {
            return -1;
        }
    }
}
