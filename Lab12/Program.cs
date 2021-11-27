﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с окружностью.");
            Console.WriteLine("Введите радиус окружности.");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circelLen = Math.Round(WorkWithCircle.CircleLen(radius), 3);
            Console.WriteLine("Длина окружности с таким радиусом равна: {0}", circelLen);
            double circelArea = Math.Round(WorkWithCircle.CircleArea(radius), 3);
            Console.WriteLine("Площадь круга с таким радиусом равна: {0}", circelArea);
            Console.WriteLine("Теперь мы определим, принадлежит ли точка с координатами (x, y) кругу с радиусом R и координатами центра x0, y0.");
            Console.WriteLine("Введите координату X точки, которую собираемся проверять.");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y точки, которую собираемся проверять.");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату X центра окружности.");
            WorkWithCircle.centerCircle_X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y центра окружности.");
            WorkWithCircle.centerCircle_Y = Convert.ToDouble(Console.ReadLine());
            if (WorkWithCircle.CheckPoint(radius, X, Y))
            {
                Console.WriteLine("Заданная точка принадлежит кругу.");
            }
            else
            {
                Console.WriteLine("Заданная точка не принадлежит кругу.");
            }
            Console.ReadKey();
        }
        static class WorkWithCircle
        {
            public static double centerCircle_X;
            public static double centerCircle_Y;
            public static double CircleLen(double radius)
            {
                return 2 * Math.PI * radius;
            }
            public static double CircleArea(double radius)
            {
                return Math.PI * radius * radius;
            }
            public static bool CheckPoint(double radius, double CheckX, double CheckY)
            {
                double CheckCorrectX = CheckX - centerCircle_X;
                double CheckCorrectY = CheckY - centerCircle_Y;
                double radiusNeeded = Math.Sqrt(CheckCorrectX * CheckCorrectX + CheckCorrectY * CheckCorrectY);
                if (Math.Round(radiusNeeded, 3) == radius)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
