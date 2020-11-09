using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Board;

namespace Snek.Shared.Entities.Consumables
{
    public class Apple : Food
    {
        private int _lifeCount = 1;
        private string _image = "apple.png";
        public Apple() : base()
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
            Console.WriteLine("I'm a cute apple");
        }
    }
}
