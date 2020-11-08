using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Board;

namespace Snek.Shared.Entities.Consumables
{
    class Ananas : Food
    {
        private int _lifeCount = 1;
        private string _image = "pineapple.png";

        public Ananas() : base()
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

    }
}
