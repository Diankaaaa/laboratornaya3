using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratornaya3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Отображение названия программы
                Console.Title = "Лабораторная работа №3";

                //Отображение уровня сложности и номера задачи
                Console.WriteLine("\t\tВысокий уровень сложности. Задача №11\n");

                //График функции +-|x| (Модуль)

                //Взаимодействие с пользователем
                Console.Write("Введите х: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите у: ");
                double y = double.Parse(Console.ReadLine());

                //result переменная для записи логического выражения
                bool result = (Math.Abs(y) <= 1) && (Math.Abs(x) <= 1) && (Math.Abs(x) <= Math.Abs(y));

                //Вывод результата
                Console.WriteLine($"Результат: {result}");

                Console.WriteLine("Для продолжения нажмите любую клавишу. . .");
                Console.ReadKey();
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
