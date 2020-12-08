using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class FoodQuest : Quest
    {
        private int _foodForCompletion = 2;
        public FoodQuest(string name) : base(name)
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
            if(progressFood >= _foodForCompletion)
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
            return "   --Eat " + _foodForCompletion + " Green Apples ";
        }
    }
}
