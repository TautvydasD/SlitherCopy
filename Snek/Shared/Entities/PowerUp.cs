using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class PowerUp
    {
        public int Duration { get; private set; }
        public string Color { get; private set; }
        public string Name { get; set; }

        public PowerUp(string name)
        {
            name = Name;
        }
    }
}
