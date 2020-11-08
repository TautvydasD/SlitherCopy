﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snek.Shared.Board
{
    public class Snake
    {
        public bool IsMovingUp { get; set; } = false;
        public bool IsMovingDown { get; set; } = false;
        public bool IsMovingRight { get; set; } = false;
        public bool IsMovingLeft { get; set; } = false;
        //public int SnakeLength { get; set; }

        public IMovement Movement { get; set; }

        public SnakeHead Head { get; set; }
        public SnakeBody Body { get; set; }
        public Coordinates pos { get; set; }
        
        public Snake() { }
        public Snake(int X, int Y)
        {
            Head.pos = new Coordinates(X, Y);
        }

        public void SetMovementSpeed(IMovement movement)
        {
            Movement = movement;
        }

        public int Speed()
        {
            return Movement.Move();
        }
        public void MovingDirection()
        {
            if (IsMovingUp) 
            {
                List<Coordinates> list = new List<Coordinates>(Body.posArr);
                list.Insert(0, new Coordinates(Head.pos.Row, Head.pos.Column));
                Body.posArr = list.ToArray();
                //Body.posList.Insert(0, new Coordinates(Head.pos.Row, Head.pos.Column));
                //Body.posList.RemoveAt(Body.posList.Count - 1);
                //Body.posArr = Body.posArr.Append(new Coordinates(Head.pos.Row, Head.pos.Column)).ToArray();
                //Body.posArr = Body.posArr.Take(Body.posArr.Count() - 1).ToArray();

                list.RemoveAt(Body.posArr.Length - 1);
                Body.posArr = list.ToArray();
                Head.pos.Row--;
            }
            else if (IsMovingDown)
            {
                List<Coordinates> list = new List<Coordinates>(Body.posArr);
                list.Insert(0, new Coordinates(Head.pos.Row, Head.pos.Column));
                Body.posArr = list.ToArray();
                //Body.posList.Insert(0, new Coordinates(Head.pos.Row, Head.pos.Column));
                //Body.posList.RemoveAt(Body.posList.Count - 1);
                //Body.posArr = Body.posArr.Append(new Coordinates(Head.pos.Row, Head.pos.Column)).ToArray();
                //Body.posArr = Body.posArr.Take(Body.posArr.Count() - 1).ToArray();

                list.RemoveAt(Body.posArr.Length - 1);
                Body.posArr = list.ToArray();
                Head.pos.Row++;
            }
            else if (IsMovingLeft)
            {
                List<Coordinates> list = new List<Coordinates>(Body.posArr);
                list.Insert(0, new Coordinates(Head.pos.Row, Head.pos.Column));
                Body.posArr = list.ToArray();
                //Body.posList.Insert(0, new Coordinates(Head.pos.Row, Head.pos.Column));
                //Body.posList.RemoveAt(Body.posList.Count - 1);
                //Body.posArr = Body.posArr.Append(new Coordinates(Head.pos.Row, Head.pos.Column)).ToArray();
                //Body.posArr = Body.posArr.Take(Body.posArr.Count() - 1).ToArray();

                list.RemoveAt(Body.posArr.Length - 1);
                Body.posArr = list.ToArray();
                Head.pos.Column--;
            }
            else if (IsMovingRight)
            {
                List<Coordinates> list = new List<Coordinates>(Body.posArr);
                list.Insert(0, new Coordinates(Head.pos.Row, Head.pos.Column));
                Body.posArr = list.ToArray();
                //Body.posList.Insert(0, new Coordinates(Head.pos.Row, Head.pos.Column));
                //Body.posList.RemoveAt(Body.posList.Count - 1);
                //Body.posArr = Body.posArr.Append(new Coordinates(Head.pos.Row, Head.pos.Column)).ToArray();
                //Body.posArr = Body.posArr.Take(Body.posArr.Count() - 1).ToArray();

                list.RemoveAt(Body.posArr.Length - 1);
                Body.posArr = list.ToArray();
                Head.pos.Column++;
            }
        }

        public void Grow()
        {
            //Body.posList.Add( new Coordinates(Head.pos.Row, Head.pos.Column));
            //Body.posArr[Body.posArr.Count()] = new Coordinates(Head.pos.Row, Head.pos.Column);
            Body.posArr = Body.posArr.Append(new Coordinates(Head.pos.Row, Head.pos.Column)).ToArray();
        }
        public void MoveUp()
        {
            if (!IsMovingDown)
            {
                IsMovingUp = true;
                IsMovingDown = false;
                IsMovingLeft = false;
                IsMovingRight = false;
            }

        }
        public void MoveDown()
        {
            if (!IsMovingUp)
            {
                IsMovingDown = true;
                IsMovingUp = false;
                IsMovingLeft = false;
                IsMovingRight = false;
            }

        }
        public void MoveLeft()
        {
            if (!IsMovingRight)
            {
                IsMovingLeft = true;
                IsMovingRight = false;
                IsMovingDown = false;
                IsMovingUp = false;
            }

        }
        public void MoveRight()
        {
            if (!IsMovingLeft)
            {
                IsMovingRight = true;
                IsMovingLeft = false;
                IsMovingDown = false;
                IsMovingUp = false;
            }

        }
    }
}
