using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Board;

namespace Snek.Shared.Entities
{
    public class LengthQuest : Quest
    {
        private int _lengthForCompletion = 6;
        public int GetLengthForCompletion()
        {
            return _lengthForCompletion;
        }
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
        /*public override bool isCompleted(int progressFood, int progressPoints, int progressLength)
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
