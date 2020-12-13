using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class PoisonFoodPointCounter : PointCounter
    {
        public PoisonFoodPointCounter(string name) : base(name)
        {

        }

        private int lifeCount = -1;

        public override void Calculate(string image)
        {
            if (image == "spoiledApple2.png" || image == "poisonedApple.png")
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
