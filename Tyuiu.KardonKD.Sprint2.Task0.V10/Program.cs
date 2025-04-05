﻿using Tyuiu.KardonKD.Sprint2.Task0.V10.Lib;

namespace Tyuiu.KardonKD.Sprint2.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1305;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Кордон К.Д. | ИСТНб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт2                                                                   *");
            Console.WriteLine("*Тема: Операции сравнения                                                  *");
            Console.WriteLine("*Задание #0                                                                *");
            Console.WriteLine("*Вариант #10                                                               *");
            Console.WriteLine("*Выполнил: Кордон Ксения Дмитриевна| ИСТНб-24-1                            *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических       *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив): (False, *");
            Console.WriteLine("  True, False, True, False, True), при x = 1305, y = 475                    ");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
