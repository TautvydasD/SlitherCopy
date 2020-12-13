using Snek.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class DisplayQuest : QuestVisitor
    {
        public override void Visit(CompositeQuest compositeQuest)
        {
            compositeQuest.Display = "Quest " + compositeQuest.Name + " : ";
        }

        public override void Visit(PointsQuest pointsQuest)
        {
            pointsQuest.Display = "   --Score " + pointsQuest.GetPointsForCompletion() + " points";
        }

        public override void Visit(LengthQuest lengthQuest)
        {
            lengthQuest.Display = "   --Get snake to length " + lengthQuest.GetLengthForCompletion();
        }

        public override void Visit(FoodQuest foodQuest)
        {
            foodQuest.Display = "   --Eat " + foodQuest.GetFoodForCompletion() + " Green Apples ";
        }
    }
}
