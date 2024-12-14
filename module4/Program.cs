

using System;
using System.Drawing;


class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет, но конечно же цветов ограниченный выбор, итак на выбор есть: \n\r красный,\n зеленый,\n голубой, \n серый,\n пурпурный,\n синий");

        Console.WriteLine("цикл while");
        int k = 7;

        while (k > 1)
        {
            Console.WriteLine("попыток осталось: {0}", k);

            k--;

            var color = Console.ReadLine();
            {
                switch (color)
                {


                    case "красный":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Ваш любимый цвет красный!");
                        break;

                    case "зеленый":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Ваш любимый цвет зеленый!");
                        break;

                    case "голубой":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("Ваш любимый цвет голубой!");
                        break;

                    case "пурпурный":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine("Цвет шрифта пурпурный!");
                        break;

                    case "серый":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine("Ваш любимый цвет серый!");
                        break;

                    case "синий":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("цвет синенький");
                        break;

                   
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Вы не выбрали цвет из списка!");
                        break;
                }
            }
        }
    }
}

