using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class BombPointCounter : PointCounter 
    {
        public BombPointCounter(string name) : base(name)
        {

        }

        private int lifeCount = -2;

        public override void Calculate(string image)
        {
            if (image == "bomb.png")
            {
                PointSum += lifeCount;
            }
            else
            {
                Next.Calculate(image);
            }
        }

        public override void SetNextChain(PointCounter next)
        {
            Next = next;
        }
    }
}
