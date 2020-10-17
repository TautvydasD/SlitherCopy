using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class Map
    {
        public List<Panel> Panels { get; set; }

        public Map()
        {
            Panels = new List<Panel>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Panels.Add(new Panel(i, j));
                }
            }
        }
    }
}
