using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities.Consumables
{
    class DoublePoints : PowerUp
    {
        private int _duration = 5;
        private string _color = "doublePoints2.png";
        public DoublePoints() : base()
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
