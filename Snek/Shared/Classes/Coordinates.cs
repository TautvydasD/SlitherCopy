using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Classes
{
    public class Coordinates
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinates(int Px, int Py)
        {
            X = Px;
            Y = Py;
        }
    }
}
