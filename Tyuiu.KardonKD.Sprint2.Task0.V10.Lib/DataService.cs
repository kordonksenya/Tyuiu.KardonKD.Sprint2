﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KardonKD.Sprint2.Task0.V10.Lib
{
    public class DataService : ISprint2Task0V10
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = x >= y;
            return res;

        }
    }
}
