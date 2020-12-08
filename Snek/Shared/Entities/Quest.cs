using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public abstract class Quest
    {
        protected string Name;
        public Quest(string name)
        {
            Name = name;
        }
        public abstract void Add(Quest quest);
        public abstract void Remove(Quest quest);
        public abstract bool isCompleted(int progressFood, int progressPoints, int progressLength);
        public abstract string Display();
    }
}
