﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class Coordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinates(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public Coordinates()
        {

        }
    }
}
