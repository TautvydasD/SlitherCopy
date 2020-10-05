using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class FoodFactory
    {

        public Food CreateFood(string foodName)
        {
            Food food = new Food(foodName);
            return food;
        }
    }
}
