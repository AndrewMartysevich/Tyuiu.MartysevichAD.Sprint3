using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MartysevichAD.Sprint3.Task3.V1.Lib;

namespace Tyuiu.MartysevichAD.Sprint3.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема:  Оператор цикла foreach                                          *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв “а” в                *");
            Console.WriteLine("* строке: have a nice time                                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string value = "have a nice time";
            char item = 'a';
            Console.WriteLine("Исходная строка  " + value);
            Console.WriteLine("Искомый символ " + item);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Количество символов " + ds.GetCharCount(value,item));
            Console.ReadKey();
        }
    }
}
