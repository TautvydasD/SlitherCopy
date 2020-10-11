using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Classes
{
    public static class Generator
    {
        private static Random Rnd = new Random();

        public static int GetRandInt(int min, int max)
        {
            return Rnd.Next(min, max);
        }

        public static Coordinates CloneCoordiantes(Coordinates Point)
        {
            return new Coordinates(Point.X, Point.Y);
        }
    }
}
