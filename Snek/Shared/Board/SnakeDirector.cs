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
        public void Construct(Coordinates headPos, List<Coordinates> bodyPosList)
        {
            
            _builder.BuildHead(headPos);
            _builder.BuildBody(bodyPosList);
        }
        public Snake GetConstructedSnake()
        {
            return _builder.Build();
        }
    }
}
