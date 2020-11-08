using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Board
{
    class ConcreteSnakeBuilder : ISnakeBuilder
    {
        Snake snake = new Snake();

        public void BuildHead(Coordinates pos)
        {
            snake.Head =  new SnakeHead(pos.Row, pos.Column);
        }
        //List<Coordinates> posList
        //public void BuildBody(List<Coordinates> posList)
        public void BuildBody(Coordinates[] posArr)
        {
            snake.Body = new SnakeBody();
            //snake.Body.posList = posList;
            snake.Body.posArr = posArr;
        }

        public Snake Build()
        {
            Snake result = snake;
            return result;
        }
    }
}
