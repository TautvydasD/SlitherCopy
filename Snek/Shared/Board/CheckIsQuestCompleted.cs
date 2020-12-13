using Snek.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class CheckIsQuestCompleted : QuestVisitor
    {
        private int _progressFood;
        private int _progressPoints;
        private int _progressLength;
        public CheckIsQuestCompleted(int progressFood, int progressPoints, int progressLength)
        {
            _progressFood = progressFood;
            _progressLength = progressLength;
            _progressPoints = progressPoints;
        }
        public override void Visit(CompositeQuest compositeQuest)
        {
            compositeQuest.IsCompleted = true;
            foreach (Quest quest in compositeQuest._children)
            {
                if (!quest.IsCompleted)
                {
                    compositeQuest.IsCompleted = false;
                }
            }
        }

        public override void Visit(PointsQuest pointsQuest)
        {
            if (_progressPoints >= pointsQuest.GetPointsForCompletion())
            {
                pointsQuest.IsCompleted = true;
            }
            else
            {
                pointsQuest.IsCompleted = false;
            }
        }

        public override void Visit(LengthQuest lengthQuest)
        {
            if (_progressLength >= lengthQuest.GetLengthForCompletion())
            {
                lengthQuest.IsCompleted = true;
            }
            else
            {
                lengthQuest.IsCompleted = false;
            }
        }

        public override void Visit(FoodQuest foodQuest)
        {
            if (_progressFood >= foodQuest.GetFoodForCompletion())
            {
                foodQuest.IsCompleted = true;
            }
            else
            {
                foodQuest.IsCompleted = false;
            }
        }
    }
}
