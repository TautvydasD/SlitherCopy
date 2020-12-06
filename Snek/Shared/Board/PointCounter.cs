using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public abstract class PointCounter
    {
        protected static int PointSum = 0;
        protected PointCounter Next;
        protected string Name;
        protected int Value;

        public PointCounter(string name)
        {
            this.Name = name;
        }

        public abstract void Calculate(string image);
        public abstract void SetNextChain(PointCounter Next);
        public int GetSum()
        {
            return PointSum;
        }
        public void SetSum(int newSum)
        {
            PointSum = newSum;
        }
    }
}
