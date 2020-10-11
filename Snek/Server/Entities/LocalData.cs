using Snek.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Server.Entities
{
    public static class LocalData
    {

        public static trashChildBoard CurrCompBoard = null;
        public static ChildWalls CurrCompWalls = null;

        public static double CompWidth = 800.0;
        public static double CompHeight = 500;

        public static string CanvasBoard;
        public static string ContextBoard;

        public static string CanvasAppName;
        public static string ContextAppName;

        public static string CanvasScore;
        public static string ContextScore;

        public static string GlobalBorderColor = "#999999";
        public static string GlobalBGColor = "lightyellow";
        public static string GlobalFont = "30px Sylfaen";

        public static Direction CurrDirection = Direction.Empty;

        public static string GameTimeTimer;

        public static int GlobalSpeed = 200;
        public static int GlobalMargin = 10;

        public static int WallCount = 20;
        public static int WallMinLength = 1;
        public static int WallMaxLength = 10;

    }
}
