using System;


namespace Консольное_приложение_2
{
    internal class Program
    {
        static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = (Console.ReadLine() ?? "").Replace(',', '.');
                if (decimal.TryParse(input, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out decimal result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка. Этот символ не является числом. Попробуйте ещё раз.");
            }
        }

        static string ReadOperation()
        {
            while (true)
            {
                Console.WriteLine("Введите знак (+ - / *)");
                string op = Console.ReadLine() ?? "";
                if (op is "+" or "-" or "/" or "*") return op;
                Console.WriteLine("Неизвестная операция. Попробуйте ещё раз.");
            }
        }
    
        static void Main(string[] args)
        {
            string cycle;
            decimal numberOne;
            decimal numberTwo;
            string symbol;
            do
            {
                Console.Clear();
                numberOne = ReadDecimal("Введите первое число:");
                ReadOperation();
                numberTwo = ReadDecimal("Введите второе число:");
                if (numberTwo == 0 && ReadOperation() == "/")
                {
                    Console.WriteLine("Ошибка. Деление на 0 невозможно. Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите дальнейшее действие:");
                            Console.WriteLine("1. Заменить 0 на другое число.");
                            Console.WriteLine("2. Заменить всё выражение целиком.");
                            symbol = Console.ReadLine() ?? "";
                            if (symbol is "1" or "2")
                            {
                                break;
                            }
                        else Console.WriteLine("Ошибка ввода. Можно ввести только 1 или 2. Попробуйте снова.");
                    }
                            if (symbol == "1")
                            {
                                Console.Clear();
                        while (true)
                        {
                            numberTwo = ReadDecimal("Введите второе число:");
                            if (numberTwo != 0) break;
                            else Console.WriteLine("Ошибка. Выберите другое число и попробуйте снова.");
                        }
                    }
                            else if (symbol == "2")
                            {
                        while (numberTwo == 0 && ReadOperation() == "/")
                        {
                            Console.Clear();
                            numberOne = ReadDecimal("Введите первое число:");
                            Console.WriteLine("Введите знак (+ - / *)");
                            ReadOperation();
                            numberTwo = ReadDecimal("Введите второе число:");
                            if (numberTwo == 0 && ReadOperation() == "/")
                            {
                                Console.WriteLine("Ошибка. Деление на ноль невозможно.");
                                Console.WriteLine("Нажмите любую клавишу для повторного введения данных.");
                                Console.ReadKey();
                            }
                        }


                    }
                    

                }
                if (ReadOperation() == "+")
                {
                    Console.WriteLine($"Результат: {numberOne + numberTwo}");
                }
                else if (ReadOperation() == "-")
                {
                    Console.WriteLine($"Результат: {numberOne - numberTwo}");
                }
                else if (ReadOperation() == "/")
                {
                    Console.WriteLine($"Результат: {numberOne / numberTwo}");
                }
                else if (ReadOperation() == "*")
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
