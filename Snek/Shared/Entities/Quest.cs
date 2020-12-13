using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Snek.Shared.Board;

namespace Snek.Shared.Entities
{
    public abstract class Quest : IEnumerable<Quest>
    {
        public string Name;
        public string Display;
        public bool IsCompleted;
        public Quest(string name)
        {
            Name = name;
            Display = "";
            IsCompleted = false;
        }
        public abstract void Add(Quest quest);
        public abstract void Remove(Quest quest);
        //public abstract bool isCompleted(int progressFood, int progressPoints, int progressLength);
        //public abstract string Display();
        public abstract IEnumerator<Quest> GetEnumerator();
        public abstract void Accept(QuestVisitor questVisitor);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
