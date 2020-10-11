using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Classes
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        Empty
    }

    public enum BlockType
    {
        Snake,
        PowerUp,
        Wall,
        Free
    }
}
