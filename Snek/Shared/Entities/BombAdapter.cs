using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class BombAdapter : Food
    {
        private Bomb bomb = new Bomb();
        public BombAdapter() : base()
        {

        }
        public override int LifeCount
        {
            get { return bomb.Explode(); }
        }
        public override string Image
        {
            get { return bomb.Image; }
        }
    }
}
