using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Snek.Shared.Helpers;

namespace Snek.Shared.Board
{
    public class Panel
    {
        public OccupationType OccupationType { get; set; }
        public Coordinates pos { get; set; }

        public Panel()
        {

        }

        public Panel(int row, int column)
        {
            pos = new Coordinates(row, column);
            OccupationType = OccupationType.Empty;
        }

        public string Status => OccupationType.GetAttributeOfType<DescriptionAttribute>().Description;

        public bool IsOccupied => OccupationType == OccupationType.Empty || OccupationType == OccupationType.Snake;
    }
}
