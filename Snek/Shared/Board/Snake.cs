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

        public Coordinates pos { get; set; }

        public Snake() { }
        public Snake(int X, int Y)
        {
            pos = new Coordinates(X, Y);
        }
        public void MovingDirection()
        {
            if (IsMovingUp)
                pos.Row--;
            else if (IsMovingDown)
                pos.Row++;
            else if (IsMovingLeft)
                pos.Column--;
            else if (IsMovingRight)
                pos.Column++;
        }
        public void MoveUp()
        {
            IsMovingUp = true;
            IsMovingDown = false;
            IsMovingLeft = false;
            IsMovingRight = false;
        }
        public void MoveDown()
        {
            IsMovingDown = true;
            IsMovingUp = false;
            IsMovingLeft = false;
            IsMovingRight = false;
        }
        public void MoveLeft()
        {
            IsMovingLeft = true;
            IsMovingRight = false;
            IsMovingDown = false;
            IsMovingUp = false;
        }
        public void MoveRight()
        {
            IsMovingRight = true;
            IsMovingLeft = false;
            IsMovingDown = false;
            IsMovingUp = false;
        }
    }
}
