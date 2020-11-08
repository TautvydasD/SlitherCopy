using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public interface ISnakeBuilder
    {
        public void BuildHead(Coordinates pos);
        //List<Coordinates> posList
        public void BuildBody(Coordinates[] posArr);
        //public void BuildBody(List<Coordinates> posList);
        public Snake Build();
    }
}
