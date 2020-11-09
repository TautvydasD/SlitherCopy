using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public interface IMap
    {
        Food CreateFood();
        PowerUp CreatePowerUp();

    }
}
