using System;
using Snek.Shared.Entities.Consumables;

namespace Snek.Shared.Entities
{
    public class SpeedFactory : Factory 
    {
        public SpeedFactory()
        {
            
        }
        public override PowerUp CreatePowerUp()
        {
            return new SpeedBoost();
        }
    }
}