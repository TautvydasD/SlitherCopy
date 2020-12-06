using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    abstract class IMemento
    {
        public abstract Snake getState();
    }
}
