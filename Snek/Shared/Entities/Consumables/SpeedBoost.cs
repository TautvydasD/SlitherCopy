﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Snek.Shared.Entities.Consumables
{
    class SpeedBoost : PowerUp
    {
        private int _duration = 5000;
        private string _color = "speed.png";
        public SpeedBoost() : base()
        {
            
        }
        // public override async void InvokeEffect(int speed)
        // {
        //     speed = 50;
        //     await Task.Delay(_duration);
        //     speed = 200;
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
