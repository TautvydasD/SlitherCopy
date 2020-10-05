using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class PowerUpFactory
    {
        public PowerUp CreatePowerUp(string powerUpName)
        {
            PowerUp powerUp = new PowerUp(powerUpName);
            return powerUp;
        }
    }
}
