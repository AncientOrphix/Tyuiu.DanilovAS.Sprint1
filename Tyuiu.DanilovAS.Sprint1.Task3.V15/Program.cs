using Tyuiu.DanilovAS.Sprint1.Task3.V15.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Данилов А. С. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Оператор составного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич |  ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, решающую следующую задачу: два автомобиля имеют     *");
            Console.WriteLine("* скорости V1 км/ч и V2 км/ч соответственно, находятся на расстоянии S км *");
            Console.WriteLine("* друг от друга и движутся в противоположные стороны.Определить расстояние*");
            Console.WriteLine("* между ними через T часов. Ответ округлите до 3 знаков после запятой.	 *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите скорость первого автомобиля:");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость второго автомобиля:");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояние между автомобилями:");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество часов, чтобы узнать, какое расстояние будет между ними через данное количество часов:");
            double T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Через " + T  + " часов автомобили будут на расстоянии " + ds.DistanceOverTime(v1,v2,S,T) + " км друг от друга.");

            Console.ReadKey();
        }
    }
}
