﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KardonKD.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            switch (value)
            {
                case 6: return "Шестерка";
                case 7: return "Семерка";
                case 8: return "Восьмерка";
                case 9: return "Девятка";
                case 10: return "Десятка";
                case 11: return "Валет";
                case 12: return "дама";
                case 13: return "Король";
                case 14: return "Туз";
                default: throw new ArgumentException("Вы ввели неподходящий номер карты");
            }
        }
    }
}
