using System;
using Snek.Shared.Entities;

namespace Snek.Shared.Entities.Consumables
{
    public class GreenApple : AppleDecorator
    {
        private int _lifeCount = 1;
        private string _image = "greenApple.png";

        public GreenApple(Food food) : base (food)
        {
        }

        public override int LifeCount
        { 
            get { return _lifeCount; }
        }
        public override string Image
        { 
            get { return _image; }
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine("It is a fresh apple");
        }

    }
}