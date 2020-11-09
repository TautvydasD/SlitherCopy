using System;
using Snek.Shared.Entities;

namespace Snek.Shared.Entities.Consumables
{
    public class PoisonApple : AppleDecorator
    {
        private int _lifeCount = 1;
        private string _image = "poisonedApple.png";

        private Food _food;
        public PoisonApple(Food food) : base (food)
        {
            this._food = food;
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
            Console.WriteLine("Uhhhh It's a poisoned apple");
        }
    }
}