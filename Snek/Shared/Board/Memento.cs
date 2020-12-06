using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    class Memento : IMemento
    {
        Snake _state;

        Memento(Snake state)
        {
            _state = state;
        }

        public override Snake getState()
        {
            return _state;
        }
    }
}
