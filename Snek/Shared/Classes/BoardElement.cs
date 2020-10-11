using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Classes
{
    public class BoardElement
    {
        public Coordinates Point { get;  set; }
        public BlockType Block { get; set; }
    }
}
