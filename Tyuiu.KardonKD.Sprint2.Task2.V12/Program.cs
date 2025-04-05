using Tyuiu.KardonKD.Sprint2.Task2.V12.Lib;
namespace Tyuiu.KardonKD.Sprint2.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Спринт #2 | Выполнил: Кордон К. Д. | ИСТНб-24-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                       *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнил: Кордон Ксения Дмитриевна | ИСТНб-24-1                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры   *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной       *");
            Console.WriteLine("* области.                                                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в закрашенной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в закрашенной области");
            }

            Console.ReadLine();
        }
    }
}
