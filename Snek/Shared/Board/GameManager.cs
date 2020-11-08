using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Snek.Shared.Classes;

namespace Snek.Shared.Board
{
    public class GameManager
    {
        private readonly int _speed = 100;
        public event EventHandler MainLoopCompleted;
        public Control powerUpControl = new Control();

        //public bool IsMovingUp { get; set; } = false;
        //public bool IsMovingDown { get; set; } = false;
        //public bool IsMovingRight { get; set; } = false;
        //public bool IsMovingLeft { get; set; } = false;

        public bool IsRunning { get; private set; } = false;

        //public Coordinates pos { get; private set; }
        public Snake snake { get; set; }
        public SnakeDirector director { get; set; }
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
                if (snake.SpeedBoost == true)
                {
                    snake.SetMovementSpeed(new MoveFast());
                }
                else if(snake.Body.posArr.Length > 10)
                {
                    snake.SetMovementSpeed(new MoveSlow());
                }
                else
                {
                    snake.SetMovementSpeed(new MoveNormal());
                }
                //await Task.Delay(_speed);
                await Task.Delay(snake.Speed());
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
            if (snake.Head.pos.Column > 9)
                snake.Head.pos.Column = -1;
            else if (snake.Head.pos.Column < 0)
                snake.Head.pos.Column = 10;
            else if (snake.Head.pos.Row > 9)
                snake.Head.pos.Row = -1;
            else if (snake.Head.pos.Row < 0)
                snake.Head.pos.Row = 10;
            //foreach(var item in snake.Body.posArr)
            //{
            //    if (item.Column > 9)
            //        item.Column = -1;
            //    else if (item.Column < 0)
            //        item.Column = 10;
            //    else if (item.Row > 9)
            //        item.Row = -1;
            //    else if (item.Row < 0)
            //        item.Row = 10;
            //}
            for (int i = 0; i < snake.Body.posArr.Length; i++)
            {
                if (snake.Body.posArr[i].Column > 9)
                    snake.Body.posArr[i].Column = -1;
                else if (snake.Body.posArr[i].Column < 0)
                    snake.Body.posArr[i].Column = 10;
                else if (snake.Body.posArr[i].Row > 9)
                    snake.Body.posArr[i].Row = -1;
                else if (snake.Body.posArr[i].Row < 0)
                    snake.Body.posArr[i].Row = 10;
            }
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
            Coordinates pos = new Coordinates(3, 0);
            List<Coordinates> posList = new List<Coordinates>();
            Coordinates[] posArr = new Coordinates[] { };
            director = new SnakeDirector(new ConcreteSnakeBuilder());
            director.Construct(pos, posArr);
            snake = director.GetConstructedSnake();
            //snake = new Snake(1, 1);
            //pos = new Coordinates(1, 1);
        }
    }
}
