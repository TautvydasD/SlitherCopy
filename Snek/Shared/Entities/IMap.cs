using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    interface IMap
    {
        public Food CreateFood(string foodName);
        public PowerUp CreatePowerUp(string powerUpName);
        public PowerUp CreatePowerUp2(string powerUpName);

    }
}
