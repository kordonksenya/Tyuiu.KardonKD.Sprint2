﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KardonKD.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7)) || ((x >= 10) && (x <= 12) && (y >= 3) && (y <= 11)) || ((x >= 6) && (x <= 9) && (y >= 5) && (y <= 8)) || ((x >= 4) && (x <= 5) && (y >= 8) && (y <= 13)) || ((x == 3) && (y == 11)) || ((x == 10) && (y == 12)) || ((x == 3) && (y == 11)) || ((x == 6) && (y >= 12) && (y <= 13)) || ((x == 9) && (y >= 3) && (y <= 4)) || ((x == 13) && (y >= 6) && (y <= 8)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
