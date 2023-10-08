﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MeshcheryakovPV.Sprint2.Task3.V16.Lib;


namespace Tyuiu.MeshcheryakovPV.Sprint2.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2| Выполнил: Мещеряков П.В. | ИИПб-23-2";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                     *");
            Console.WriteLine("* Задание #3                                              *");
            Console.WriteLine("* Вариант #6                                              *");
            Console.WriteLine("* Выполнил Мещеряков П.В. | ИИПб-23-2                     *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение *");
            Console.WriteLine("*функции Y с использованием вложенных операторов if-else, *");
            Console.WriteLine("*где пользователь вводит значение  Х с клавиатуры.        *");
            Console.WriteLine("*Полученное значение округлить до 3 знаков после запятой. *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите значение переменной Х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x);



            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
