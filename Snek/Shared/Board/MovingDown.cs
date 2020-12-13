using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    class MovingDown : State
    {
        public override void MovingDirection()
        {
            List<Coordinates> list = new List<Coordinates>(_snake.Body.posArr);
            list.Insert(0, new Coordinates(_snake.Head.pos.Row, _snake.Head.pos.Column));
            _snake.Body.posArr = list.ToArray();

            list.RemoveAt(_snake.Body.posArr.Length - 1);
            _snake.Body.posArr = list.ToArray();
            _snake.Head.pos.Row++;
        }
    }
}
