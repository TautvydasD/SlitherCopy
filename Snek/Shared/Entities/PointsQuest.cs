using Snek.Shared.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class PointsQuest : Quest
    {
        private int _pointsForCompletion = 3;
        public int GetPointsForCompletion()
        {
            return _pointsForCompletion;
        }
        public PointsQuest(string name) : base(name)
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

        /*public override bool isCompleted(int progressFood, int progressPoints, int progressLength)
        {
            if(progressPoints >= _pointsForCompletion)
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
            return "   --Score " + _pointsForCompletion + " points";
        }*/

        public override IEnumerator<Quest> GetEnumerator()
        {
            yield break;
        }

        public override void Accept(QuestVisitor questVisitor)
        {
            questVisitor.Visit(this);
        }
    }
}
