using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    class Map
    {
        Food food;
        PowerUp powerUp;
        public string Name { get; private set; }
        public int Length { get; private set; }
        public int Height { get; private set; }
        
        public Map(IMap chosenMap)
        {
            food = chosenMap.CreateFood();
            powerUp = chosenMap.CreatePowerUp();
        }
    }
}
