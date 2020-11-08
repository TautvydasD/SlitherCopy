using System;
using Snek.Shared.Entities.Consumables;

namespace Snek.Shared.Entities
{
    public class DoublePointsFactory : Factory
    {
        public DoublePointsFactory()
        {
            
        }

        public override PowerUp CreatePowerUp()
        {
            return new DoublePoints();
        }
    }
}