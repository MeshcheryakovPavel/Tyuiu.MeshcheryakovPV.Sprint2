using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MeshcheryakovPV.Sprint2.Task5.V8.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2| Выполнил: Мещеряков П.В. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил Мещеряков П.В. | ИИПб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Дата некоторого дня определяется двумя натуральными числами:            *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число).                                *");
            Console.WriteLine("* По заданным m и n определить дату предыдущего дня                       *");
            Console.WriteLine("* (принять, что m и n не определяют 1 января).                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число (1 - 31): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц (1 - январь, 2 - февраль, и так далее): ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfPreviousDay(m, n);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}