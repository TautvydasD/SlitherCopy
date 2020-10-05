using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class Food
    {
        public int LifeCount { get; private set; }
        public string Color { get; private set; }
        public string Name { get; set; }

        public Food(string name)
        {
            name = Name;
        }
    }
}
