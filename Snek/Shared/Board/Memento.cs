using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    class Memento : IMemento
    {
        bool _speedState;
        bool _shrinkState;
        bool _doublePointsState;

        public Memento(bool speed, bool shrink, bool doublePoints)
        {
            _speedState = speed;
            _shrinkState = shrink;
            _doublePointsState = doublePoints;
        }

        public override bool getShrinkState()
        {
            return _shrinkState;
        }
        public override bool getSpeedState()
        {
            return _speedState;
        }
        public override bool getDoublePointsState()
        {
            return _doublePointsState;
        }
    }
}
