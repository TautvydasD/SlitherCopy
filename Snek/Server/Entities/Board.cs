using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Classes;

namespace Snek.Server.Entities
{
    public static class Board
    {
        public static List<Wall> Walls = new List<Wall>();

        public static BoardElement[,] Matrix = new BoardElement[1, 1];

        public static void InitializeMatrix()
        {
            Matrix = new BoardElement[Game.XLength, Game.YLength];

            for (int indexX = 0; indexX < Game.XLength; indexX++)
            {
                for (int indexY = 0; indexY < Game.YLength; indexY++)
                {
                    Matrix[indexX, indexY] = new BoardElement()
                    {
                        Point = new Coordinates(indexX, indexY),
                        Block = BlockType.Free
                        
                    };
                }
            }
        }
    }
}
