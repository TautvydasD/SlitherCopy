using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Snek.Shared.Classes;

namespace Snek.Server.Entities
{
    public static class Game
    {

        public static Timer TimerClock;

        public static bool IsBotMode = false;

        public static int RecursionCounter;
        
        public static int XLength = 30;
        public static int YLength = 30;
        
        public static int PointCounter;
        
        public static double PointWidth;
        public static double PointHeight;
        
        public static bool IsStarted = false;
        public static bool IsEnabled = false;
        
        public static List<SnakeElement> SnakeElements;
        public static bool BordersOpened = true;
        public static Coordinates TargetPos;

        public static bool CtrlDoubleSpeed = false;
        public static bool ShiftHalfSpeed = false;
    
        public static void MoveToDirection()
        {

        }

        public static void GameOver()
        {
            TimerClock.Dispose();
        }

        public static void TimerReset()
        {
            if (TimerClock != null)
            {
                TimerClock.Dispose();
            }
            TimerClock = new Timer(TimerCallBack, null, 0, LocalData.GlobalSpeed);
        }

        public static void TimerCallBack(Object StateInfo)
        {
            MoveToDirection();
            LocalData.CurrCompBoard.Refresh();
        }
    }

}
