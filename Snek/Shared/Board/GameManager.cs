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
        public event EventHandler MainLoopCompleted;
        public Control powerUpControl { get; set; }

        public bool IsRunning { get; private set; } = false;

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
                await Task.Delay(snake.Speed());
            }
        }
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
            powerUpControl = new Control(snake);
        }
    }
}
