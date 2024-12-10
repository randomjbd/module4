

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        Console.WriteLine("cписок доступных цветов:\n blue, \n magenta, \n yellow.");
        Console.WriteLine();

        var color = Console.ReadLine();

      if (color == "blue")
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("Your color is blue (on the white background)!");
}

      else if (color == "magenta")
{
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.ForegroundColor = ConsoleColor.Magenta;

    Console.WriteLine("Your color is (on the gray background)!");
}

        else if (color == "yellow")
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Your color is yellow (on the black background)!");
        }

        else
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.WriteLine("Your color is else (on the Darkred background)!");
}
  }
}