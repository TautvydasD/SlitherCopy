using Snek.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Snek.Shared.Entities.Consumables;

namespace Snek.Shared.Board
{
    public class Snake
    {
        //public int SnakeLength { get; set; }
        public bool SpeedBoost { get; set; } = false;

        public IMovement Movement { get; set; }

        public SnakeHead Head { get; set; }
        public SnakeBody Body { get; set; }
        public Coordinates pos { get; set; }

        private State _state = null;
        public Snake() {
            _state = new MovingRight();
            _state.setSnake(this);
        }
        public Snake(int X, int Y)
        {
            Head.pos = new Coordinates(X, Y);
            _state = new MovingRight();
            _state.setSnake(this);
        }

        public void SetMovementSpeed(IMovement movement)
        {
            Movement = movement;
        }

        public int Speed()
        {
            return Movement.Move();
        }
        public void MovingDirection()
        {
            _state.MovingDirection();
        }

        public void Grow()
        {
            //Body.posList.Add( new Coordinates(Head.pos.Row, Head.pos.Column));
            //Body.posArr[Body.posArr.Count()] = new Coordinates(Head.pos.Row, Head.pos.Column);
            Body.posArr = Body.posArr.Append(new Coordinates(Head.pos.Row, Head.pos.Column)).ToArray();
        }
        public void MoveUp()
        {
            if (_state.GetType() != typeof(MovingDown))
            {
                _state = new MovingUp();
                _state.setSnake(this);
            }
        }
        public void MoveDown()
        {
            if (_state.GetType() != typeof(MovingUp))
            {
                _state = new MovingDown();
                _state.setSnake(this);
            }
        }
        public void MoveLeft()
        {
            if (_state.GetType() != typeof(MovingRight))
            {
                _state = new MovingLeft();
                _state.setSnake(this);
            }
        }
        public void MoveRight()
        {
            if (_state.GetType() != typeof(MovingLeft))
            {
                _state = new MovingRight();
                _state.setSnake(this);
            }
        }
        public void UsePowerUp(PowerUp powerUp)
        {
            if(powerUp is SpeedBoost)
            {
                SpeedBoost = true;
            }
            if (powerUp is DoublePoints)
            {
            }
            if (powerUp is CoinBox)
            {
            }
            if (powerUp is Shrink)
            {

            }
        }

        public void DiscardPowerUp(PowerUp powerUp)
        {
            if (powerUp is SpeedBoost)
            {
                SpeedBoost = false;
            }
            if (powerUp is DoublePoints)
            {
            }
            if (powerUp is CoinBox)
            {
            }
            if (powerUp is Shrink)
            {

            }
        }
    }
}
