using System;
using Snek.Shared.Entities;

namespace Snek.Shared.Entities.Consumables
{
    public abstract class AppleDecorator : Food
    {
        private Food _food;

        public AppleDecorator(Food food)
        {
            this._food = food;
        }
    }
}