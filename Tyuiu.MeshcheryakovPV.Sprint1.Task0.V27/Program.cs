using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MeshcheryakovPV.Sprint1.Task0.V27.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint1.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1305;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #1 | Выполнил: Мещеряков П.В. | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: АЛГОРИТМЫ РАЗВЕТВЛЯЮЩЕЙСЯ СТРУКТУРЫ                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил Мещеряков П.В. | ИИПб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)

            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }
}
