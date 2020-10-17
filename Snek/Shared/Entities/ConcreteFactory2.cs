using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class ConcreteFactory2 : IMap
    {
        public Food CreateFood(string foodName)
        {
            throw new NotImplementedException();
        }

        public PowerUp CreatePowerUp(string powerUpName)
        {
            PowerUp powerUp = new PowerUp(powerUpName);
            return powerUp;
        }

        public PowerUp CreatePowerUp2(string powerupName) 
        {
            PowerUp powerUp = new PowerUp(powerupName);
            return powerUp;
        }
    }
}
