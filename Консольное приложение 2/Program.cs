using System;
using System.Runtime.CompilerServices;


namespace Консольное_приложение_2
{
    internal class Program
    {
        static decimal ReadDecimal(string message)
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
            string symbol;
            do
            {
                Console.Clear();
                numberOne = ReadDecimal("Введите первое число:");
                while (true)
                {
                    Console.WriteLine("Введите знак (+ - / *)");
                    operation = Console.ReadLine() ?? "";
                    if (operation is "+" or "-" or "/" or "*") break;
                    Console.WriteLine("Неизвестная операция. Попробуйте ещё раз.");
                }
                numberTwo = ReadDecimal("Введите второе число:");
                if (numberTwo == 0 && operation == "/")
                {
                    Console.WriteLine("Ошибка. Деление на 0 невозможно. Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите дальнейшее действие:");
                            Console.WriteLine("1. Заменить 0 на другое число.");
                            Console.WriteLine("2. Заменить всё выражние целиком.");
                            symbol = Console.ReadLine() ?? "";
                            if (symbol is "1" or "2")
                            {
                                break;
                            }
                        }
                            if (symbol == "1")
                            {
                                Console.Clear();
                                numberTwo = ReadDecimal("Введите второе число:");
                            }
                            else if (symbol == "2")
                            {
                                Console.Clear();
                                numberOne = ReadDecimal("Введите первое число:");
                        Console.WriteLine("Введите знак (+ - / *)");
                            while (true)
                            {
                                operation = Console.ReadLine() ?? "";
                                if (operation is "+" or "-" or "/" or "*") break;
                                Console.WriteLine("Неизвестная операция. Попробуйте ещё раз.");
                            }
                                numberTwo = ReadDecimal("Введите второе число:");
                            

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

