using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class NoFoodCounter : PointCounter
    {
        public NoFoodCounter(string name) : base(name)
        {

        }

        public override void Calculate(string image)
        {
            Console.WriteLine("Bad input");
        }

        public override void SetNextChain(PointCounter next)
        {
            Next = next;
        }

    }
}
