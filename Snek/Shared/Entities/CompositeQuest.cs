using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Snek.Shared.Board;

namespace Snek.Shared.Entities
{
    public class CompositeQuest : Quest
    {
        public List<Quest> _children = new List<Quest>();
        public CompositeQuest(string name) : base(name)
        {

        }

        public override void Add(Quest quest)
        {
            _children.Add(quest);
        }

        public override void Remove(Quest quest)
        {
            _children.Remove(quest);
        }
        /*public override bool isCompleted(int progressFood, int progressPoints, int progressLength)
        {
            bool done = true;
            foreach(Quest quest in _children)
            {
                if(!quest.isCompleted(progressFood, progressPoints, progressLength))
                {
                    done = false;
                }
            }
            return done;
        }
        public override string Display()
        {
            //foreach(Quest quest in _children)
            //{
            //    quest.Display();
            //}
            return "Quest " + Name + " : ";
        }*/

        public override IEnumerator<Quest> GetEnumerator()
        {
            var quests = new Stack<Quest>(new[] { this } );
            while (quests.Any())
            {
                Quest quest = quests.Pop();
                yield return quest;
                var compositeQuest = quest as CompositeQuest;
                if(compositeQuest != null)
                {
                    foreach(var q in compositeQuest._children)
                    {
                        quests.Push(q);
                    }
                }
            }
        }
        public override void Accept(QuestVisitor questVisitor)
        {
            questVisitor.Visit(this);
        }
    }
}
