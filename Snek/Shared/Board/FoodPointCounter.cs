using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class FoodPointCounter : PointCounter
    {
        public FoodPointCounter(string name) : base(name)
        {

        }

        private int lifeCount = 1;

        public override void Calculate(string image)
        {
            if(image == "cherry.png" || image == "cherry2.png" || image == "pineapple.png" || image == "apple.png" || image == "greenApple.png")
            {
                PointSum += lifeCount;
                Next.Calculate(image);
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
