using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    interface IMap
    {
        Food CreateFood();
        PowerUp CreatePowerUp();

    }
}
