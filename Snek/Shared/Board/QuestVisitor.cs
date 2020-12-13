using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Entities;

namespace Snek.Shared.Board
{
    public abstract class QuestVisitor
    {
        public abstract void Visit(LengthQuest lengthQuest);
        public abstract void Visit(FoodQuest foodQuest);
        public abstract void Visit(CompositeQuest compositeQuest);
        public abstract void Visit(PointsQuest pointsQuest);
    }
}
