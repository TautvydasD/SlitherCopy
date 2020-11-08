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
        public async void InvokeEffect(Func<int> getter, Action<int> setter)
        {
            var speed = getter();
            setter(speed = 50);
            await Task.Delay(5000);
            setter(speed = 200);
        }
        private Coordinates GeneratePosition()
        {
            var rnd = new Random();
            var row = rnd.Next(0,9);
            var column = rnd.Next(0,9);
            return new Coordinates(row, column);

        }
    }
}
