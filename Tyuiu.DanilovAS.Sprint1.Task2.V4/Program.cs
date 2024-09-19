using Tyuiu.DanilovAS.Sprint1.Task2.V4.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1 | Выполнил: Данилов А. С. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операции в C#                                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич |  ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*  выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Формулировка задания:                                                   *");
            Console.WriteLine("* - Известна длина стороны квадрата. Вычислить площадь квадрата.          *");
            Console.WriteLine("* Что пользователь вводит? 									             *");
            Console.WriteLine("* - Длина стороны квадрата (целое число)                                  *");
            Console.WriteLine("* Что программа печатает на экране?									     *");
            Console.WriteLine("* -  Площадь квадрата (целое число)									     *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите длину стороны квадрата, чтобы узнать площать: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площать квадарата равна = " + ds.CalculateSquare(x)); 
            Console.ReadKey();
        }
    }
}
