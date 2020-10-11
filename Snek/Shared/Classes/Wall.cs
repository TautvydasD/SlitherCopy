using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Classes
{
    public class Wall
    {
        public int Lenght { get; private set; }
        public Direction Direct { get; private set; }
        public Coordinates StarterPoint { get; private set; }
    }
}
