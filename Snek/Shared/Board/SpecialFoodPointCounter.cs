using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class SpecialFoodPointCounter : PointCounter
    {
        public SpecialFoodPointCounter(string name) : base(name)
        {

        }

        private int lifeCount = 2;

        public override void Calculate(string image)
        {
            if (image == "rainbowApple.png" || image == "greenApple.png")
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
