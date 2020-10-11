using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Snek.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Server.Entities
{
    public class ChildWalls : ComponentBase
    {
        List<Rectan> Rectans = new List<Rectan>();

        protected override void OnAfterRender(bool firstRender)
        {
            if (LocalData.CurrCompWalls is null)
                LocalData.CurrCompWalls = this;
            base.OnAfterRender(firstRender);
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            Rectans = new List<Rectan>();
            PaintWalls();
            CmdRender(0,  builder);
            Rectans = new List<Rectan>();
            base.BuildRenderTree(builder);
        }

        public void Refresh()
        {
            StateHasChanged();
        }

        public void PaintWalls()
        {
            int w = 0;
            int h = 0;
            foreach (var item in Board.Walls)
            {
                if ((int)item.Direct > 1)
                {
                    w = item.Lenght;
                    h = 1;
                }
                else
                {
                    w = 1;
                    h = item.Lenght;
                }

                Rectans.Add(new Rectan
                {
                    PosX = Math.Round(item.StarterPoint.X * Game.PointWidth, 2),
                    PosY = Math.Round(item.StarterPoint.Y * Game.PointHeight, 2),
                    Width = Game.PointWidth * w,
                    Height = Game.PointHeight * h
                });
            }
        }

        public void CmdRender(int k, RenderTreeBuilder builder)
        {
            builder.OpenElement(k++, "g");
            builder.AddAttribute(k++, "fill", "#999999");

            foreach (var item in Rectans)
            {
                builder.OpenElement(k++, "rect");
                builder.AddAttribute(k++, "x", item.PosX);
                builder.AddAttribute(k++, "y", item.PosY);
                builder.AddAttribute(k++, "width", item.Width);
                builder.AddAttribute(k++, "height", item.Height);
                builder.CloseElement();
            }

            builder.CloseElement();
        }

        public void Dispose()
        {

        }
    }
}
