using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class CompositeQuest : Quest
    {
        private List<Quest> _children = new List<Quest>();

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
        public override bool isCompleted(int progressFood, int progressPoints, int progressLength)
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
            foreach(Quest quest in _children)
            {
                quest.Display();
            }
            return "Quest " + Name + " : ";
        }
    }
}
