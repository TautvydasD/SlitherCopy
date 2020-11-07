using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class Snake
    {
        public bool IsMovingUp { get; set; } = false;
        public bool IsMovingDown { get; set; } = false;
        public bool IsMovingRight { get; set; } = false;
        public bool IsMovingLeft { get; set; } = false;

        public SnakeHead Head { get; set; }
        public SnakeBody Body { get; set; }
        public Coordinates pos { get; set; }

        public Snake() { }
        public Snake(int X, int Y)
        {
            Head.pos = new Coordinates(X, Y);
            Body.posList = null;
        }
        public void MovingDirection()
        {
            if (IsMovingUp)
                Head.pos.Row--;
            else if (IsMovingDown)
                Head.pos.Row++;
            else if (IsMovingLeft)
                Head.pos.Column--;
            else if (IsMovingRight)
                Head.pos.Column++;
        }
        public void MoveUp()
        {
            if (!IsMovingDown)
            {
                IsMovingUp = true;
                IsMovingDown = false;
                IsMovingLeft = false;
                IsMovingRight = false;
            }

        }
        public void MoveDown()
        {
            if (!IsMovingUp)
            {
                IsMovingDown = true;
                IsMovingUp = false;
                IsMovingLeft = false;
                IsMovingRight = false;
            }

        }
        public void MoveLeft()
        {
            if (!IsMovingRight)
            {
                IsMovingLeft = true;
                IsMovingRight = false;
                IsMovingDown = false;
                IsMovingUp = false;
            }

        }
        public void MoveRight()
        {
            if (!IsMovingLeft)
            {
                IsMovingRight = true;
                IsMovingLeft = false;
                IsMovingDown = false;
                IsMovingUp = false;
            }

        }
    }
}
