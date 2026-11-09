using System;


namespace Консольное_приложение_2
{
    internal class Program
    {
        static decimal ReadFloat(string message)
        {
            while(true)
            {
                Console.WriteLine(message);
                string input = (Console.ReadLine() ?? "").Replace(',', '.');
                if (decimal.TryParse(input, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out decimal result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка. Этот символ не является числом. Попробуйте ещё раз.");
            }
        }
        static void Main(string[] args)
        {
            string cycle;
            decimal numberOne;
            decimal numberTwo;
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
                    while (true)
                    {
                        Console.WriteLine("Ошибка. Деление на 0 невозможно. Попробуйте использовать другое значение второго числа.");
                        if (operation == "/")
                        {
                            numberTwo = ReadFloat("Введите второе число:");
                            if (numberTwo != 0) break;
                        }
                    }
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
                    Console.WriteLine("Заново? (да / нет)");
                cycle = (Console.ReadLine() ?? "").Trim().ToLower();
            } while (cycle == "да");
            if (cycle == "нет")
            { 
                    Console.Clear();
                    Console.WriteLine("Спасибо за использование.");
                    Console.WriteLine("Вы можете выйти с помощью нажатия любой клавиши.");
                Console.ReadKey();
            }
        }
    }
}
 
