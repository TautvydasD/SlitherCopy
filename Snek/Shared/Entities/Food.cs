using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Board;

namespace Snek.Shared.Entities
{
    public abstract class Food
    {
        public abstract int LifeCount { get;}
        public abstract string Image { get;}

        public Coordinates Position { get; }
        public Food()
        {
            Position = GeneratePosition();
        }

        private Coordinates GeneratePosition()
        {
            var rnd = new Random();
            var row = rnd.Next(0,9);
            var column = rnd.Next(0,9);
            return new Coordinates(row, column);

        }
        
        public virtual void ToConsole()
        {
            Console.WriteLine("I am a fruit");
        }

    }
}
