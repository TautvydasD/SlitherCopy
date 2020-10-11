using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.RenderTree;
using Snek.Shared.Classes;

namespace Snek.Server.Entities
{
    public class trashChildBoard : ComponentBase
    {
        List<Rectan> Rectans = new List<Rectan>();

        protected override void OnAfterRender(bool firstRender)
        {
            if (LocalData.CurrCompBoard is null)
                LocalData.CurrCompBoard = this;
            base.OnAfterRender(firstRender);
        }

        public void Refresh()
        {
            StateHasChanged();
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            Rectans = new List<Rectan>();
            PaintMatrix();
            CmdRender(0, builder);
            Rectans = new List<Rectan>();
            base.BuildRenderTree(builder);
        }

        public void PaintMatrix()
        {
            for (int indexX = 0; indexX < Game.XLength; indexX++)
                for (int indexY = 0; indexY < Game.YLength; indexY++)
                    if (Board.Matrix[indexX,indexY].Block != BlockType.Free)
                        if (Board.Matrix[indexX, indexY].Block != BlockType.Wall)
                            PaintBoardElement(Board.Matrix[indexX, indexY]);
        }

        public void SelectCell(int x, int y)
        {
            string _style = "fill:none;stroke:green;stroke-width=2";

            Rectans.Add(new Rectan{
                PosX = Math.Round(x * Game.PointWidth, 2),
                PosY = Math.Round(y * Game.PointHeight, 2),
                Width = Game.PointWidth,
                Height = Game.PointHeight,
                Style = _style
            });
        }

        public void PaintBoardElement(BoardElement boardElement)
        {
            string _style = "fill:red";

            if (boardElement.Block == BlockType.Snake)
            {
                _style = "fill:blue";

                SnakeElement snakeElement = Game.SnakeElements.Where(x => x.IsMain).ToList()[0];

                if (snakeElement.Point.X == boardElement.Point.X && snakeElement.Point.Y == boardElement.Point.Y)
                    _style = "fill:blue;stroke:red;stroke-width:3";
            }

            Rectans.Add(new Rectan {
                PosX = Math.Round(boardElement.Point.X * Game.PointWidth, 2),
                PosY = Math.Round(boardElement.Point.Y * Game.PointHeight, 2),
                Width = Game.PointWidth,
                Height = Game.PointHeight,
                Style = _style
            });

        }

        public void CmdRender(int k, RenderTreeBuilder builder)
        {
            builder.OpenElement(k++, "g");

            foreach (var item in Rectans)
            {
                builder.OpenElement(k++, "rect");
                builder.AddAttribute(k++, "x", item.PosX);
                builder.AddAttribute(k++, "y", item.PosY);
                builder.AddAttribute(k++, "width", item.Width);
                builder.AddAttribute(k++, "height", item.Height);
                builder.AddAttribute(k++, "style", item.Style);
                builder.CloseElement();
            }

            builder.CloseElement();
        }

        public void Dispose()
        {

        }
    }
}
