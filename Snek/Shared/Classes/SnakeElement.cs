using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Classes
{
    public class SnakeElement
    {
        public Coordinates Point { get; private set; }
        public bool IsMain { get; private set; }
    }
}
