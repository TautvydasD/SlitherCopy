using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    public class SnakeDirector
    {
        public ISnakeBuilder _builder;
        public SnakeDirector(ISnakeBuilder builder)
        {
            _builder = builder;
        }
        //List<Coordinates> bodyPosList
        //public void Construct(Coordinates headPos, List<Coordinates> bodyPosList)
        public void Construct(Coordinates headPos, Coordinates[] bodyPosArr)
        {
            
            _builder.BuildHead(headPos);
            //_builder.BuildBody(bodyPosList);
            _builder.BuildBody(bodyPosArr);
        }
        public Snake GetConstructedSnake()
        {
            return _builder.Build();
        }
    }
}
