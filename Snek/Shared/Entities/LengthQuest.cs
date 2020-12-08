using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class LengthQuest : Quest
    {
        private int _lengthForCompletion = 6; 
        public LengthQuest(string name) : base(name)
        {

        }

        public override void Add(Quest quest)
        {
            Console.WriteLine("Cannot add to leaf quest");
        }

        public override void Remove(Quest quest)
        {
            Console.WriteLine("Cannot remove from leaf quest");
        }
        public override bool isCompleted(int progressFood, int progressPoints, int progressLength)
        {
            if(progressLength >= _lengthForCompletion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string Display()
        {
            return "   --Get snake to length : " + _lengthForCompletion;
        }
    }
}
