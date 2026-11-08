using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольное_приложение_2
{
    internal class Program
    {
        static float ReadFloat(string message)
        {
            while(true)
            {
                Console.WriteLine(message);
                string input = (Console.ReadLine() ?? "").Replace(',', '.');
                if (float.TryParse(input, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка. Этот символ не является числом. Попробуйте ещё раз.");
            }
        }
        static void Main(string[] args)
        {
            string cycle;
            float numberOne;
            float numberTwo;
            string operation;
            do
            {
                Console.Clear();
                numberOne = ReadFloat("Введите первое число:");
                while (true)
                {
                    Console.WriteLine("Введите знак (+ - / *)");
                    operation = Console.ReadLine() ?? "";
                    if (operation is "+" or "-" or "/" or "*") break;
                    Console.WriteLine("Неизвестная операция. Попробуйте ещё раз.");
                }
                numberTwo = ReadFloat("Введите второе число:");
                if (numberTwo == 0 && operation == "/")
                {
                    Console.WriteLine("Ошибка. Деление на 0 невозможно. Попробуйте использовать другое число.");
                }
                if (operation == "+")
                {
                    Console.WriteLine($"Результат: {numberOne + numberTwo}");
                }
                else if (operation == "-")
                {
                    Console.WriteLine($"Результат: {numberOne - numberTwo}");
                }
                else if (operation == "/")
                {
                    Console.WriteLine($"Результат: {numberOne / numberTwo}");
                }
                else if (operation == "*")
                {
                    Console.WriteLine($"Результат: {numberOne * numberTwo}");
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения.");
                Console.ReadKey();
                Console.Clear();
                    Console.WriteLine("Заного? (да / нет)");
                cycle = (Console.ReadLine() ?? "").Trim().ToLower();
            } while (cycle == "да");
            if (cycle == "нет")
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Спасибо за использование.");
                    Console.WriteLine("Вы можете выйти с помощью нажатия любой клавиши, или программа автоматически выключится сама.");
                    Thread.Sleep(5500);
                    Console.Clear();
                }
            }
        }
    }
}

