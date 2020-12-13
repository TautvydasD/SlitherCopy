using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public abstract class IMemento
    {
        public abstract bool getSpeedState();
        public abstract bool getShrinkState();
        public abstract bool getDoublePointsState();
    }
}
