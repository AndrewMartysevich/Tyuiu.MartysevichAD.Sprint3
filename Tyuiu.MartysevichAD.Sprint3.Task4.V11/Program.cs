﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MartysevichAD.Sprint3.Task4.V11.Lib;

namespace Tyuiu.MartysevichAD.Sprint3.Task4.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах               *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение   * ");
            Console.WriteLine("* функции y=x/(sin(x) - x)+2 При х = 0 пропустить значение.              *");
            Console.WriteLine("* Полученные значения перемножать.                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");;
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт Шага " + startValue);
            Console.WriteLine("Конец Шага " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение ряда " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
