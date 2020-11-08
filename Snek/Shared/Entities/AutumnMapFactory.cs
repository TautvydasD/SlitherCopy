using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Entities.Consumables;
using Snek.Shared.Board;

namespace Snek.Shared.Entities
{
    public class AutumnMapFactory : IMap
    {
        public Food CreateFood()
        {
            return new Cherry();
        }

        public PowerUp CreatePowerUp()
        {
            return new CoinBox();
        }
    }
}
