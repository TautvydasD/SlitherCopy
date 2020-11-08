using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities.Consumables
{
    class Shrink : PowerUp
    {
        private int _duration = 5;
        private string _color = "shrink.png";
        public Shrink() : base()
        {
            
        }
        // public override void InvokeEffect(int speed)
        // {
        //     throw new NotImplementedException();
        // }
        public override int Duration
        { 
            get { return _duration; }
        }

        public override string Color
        {
            get { return _color; }
        }
    }
}
