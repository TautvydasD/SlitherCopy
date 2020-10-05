using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class FoodFactory : IMap
    {

        public Food CreateFood(string foodName)
        {
            Food food = new Food(foodName);
            return food;
        }

        // baaaaaaaaaaad
        public PowerUp CreatePowerUp(string powerUpName)
        {
            throw new NotImplementedException();
        }
    }
}
