using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Board;
using System.Threading.Tasks;

namespace Snek.Shared.Entities
{
    public abstract class PowerUp
    {
        public abstract int Duration { get; }
        public abstract string Color { get; }

        public Coordinates Position { get; }
        public PowerUp()
        {
            Position = GeneratePosition();
        }
        public async void InvokeEffect(Snake snake)
        {
            snake.SetMovementSpeed(new MoveFast());
            await Task.Delay(5000);
            snake.SetMovementSpeed(new MoveNormal());
        }
        // public async void InvokeEffect(Snake snake)
        // {
        //     snake.SetMovementSpeed()
        //     await Task.Delay(5000);
        // }
        private Coordinates GeneratePosition()
        {
            var rnd = new Random();
            var row = rnd.Next(0,9);
            var column = rnd.Next(0,9);
            return new Coordinates(row, column);

        }
    }
}
