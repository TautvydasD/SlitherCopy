using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    abstract class State
    {
        protected Snake _snake;
        public void setSnake(Snake snake)
        {
            _snake = snake;
        }
        public abstract void MovingDirection();
    }
}
