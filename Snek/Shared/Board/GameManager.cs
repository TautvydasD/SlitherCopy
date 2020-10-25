using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snek.Shared.Board
{
    public class GameManager
    {
        private readonly int _speed = 200;
        public event EventHandler MainLoopCompleted;

        //public bool IsMovingUp { get; set; } = false;
        //public bool IsMovingDown { get; set; } = false;
        //public bool IsMovingRight { get; set; } = false;
        //public bool IsMovingLeft { get; set; } = false;

        public bool IsRunning { get; private set; } = false;

        //public Coordinates pos { get; private set; }
        public Snake snake { get; set; }
        public GameManager()
        {
            ResetGameObjects();
        }
        public async void MainLoop()
        {
            IsRunning = true;

            while (IsRunning)
            {
                Transition();
                //MovingDirection();
                snake.MovingDirection();
                MainLoopCompleted?.Invoke(this, EventArgs.Empty);
                await Task.Delay(_speed);
            }
        }
        //public void MovingDirection()
        //{
        //    if (IsMovingUp)
        //        pos.Row--;
        //    else if (IsMovingDown)
        //        pos.Row++;
        //    else if (IsMovingLeft)
        //        pos.Column--;
        //    else if (IsMovingRight)
        //        pos.Column++;
        //}

        //public void MoveUp()
        //{
        //    IsMovingUp = true;
        //    IsMovingDown = false;
        //    IsMovingLeft = false;
        //    IsMovingRight = false;
        //}
        //public void MoveDown()
        //{
        //    IsMovingDown = true;
        //    IsMovingUp = false;
        //    IsMovingLeft = false;
        //    IsMovingRight = false;
        //}
        //public void MoveLeft()
        //{
        //    IsMovingLeft = true;
        //    IsMovingRight = false;
        //    IsMovingDown = false;
        //    IsMovingUp = false;
        //}
        //public void MoveRight()
        //{
        //    IsMovingRight = true;
        //    IsMovingLeft = false;
        //    IsMovingDown = false;
        //    IsMovingUp = false;
        //}
        public void Transition()
        {
            if (snake.pos.Column > 9)
                snake.pos.Column = -1;
            else if (snake.pos.Column < 0)
                snake.pos.Column = 10;
            else if (snake.pos.Row > 9)
                snake.pos.Row = -1;
            else if (snake.pos.Row < 0)
                snake.pos.Row = 10;
        }
        public void StartGame()
        {
            if (!IsRunning)
            {
                ResetGameObjects();
                MainLoop();
            }
        }
        private void GameOver()
        {
            IsRunning = false;
        }
        private void ResetGameObjects()
        {
            snake = new Snake(1, 1);
            //pos = new Coordinates(1, 1);
        }
    }
}
