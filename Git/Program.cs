using System;
using static System.Console;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите число:");
            int input = Convert.ToInt32(Console.ReadLine());
            WriteLine("Введённое число:" + input);
            WriteLine($"Введённое число + 20:\t{input + 20}");
        }
    }
}
