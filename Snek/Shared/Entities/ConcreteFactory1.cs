using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class ConcreteFactory1 : IMap
    {
        public Food CreateFood(string foodName)
        {
            Food food = new Food(foodName);
            return food;
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
