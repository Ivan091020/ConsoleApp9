using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Введите значение х: ");
            int x = int.Parse(Console.ReadLine());
            // Первый способ с использованием учловного оператора
            double result1 = CalculateFunctionWithIf(x);
            // Второй способ с использованием уcловного оператора
            double result2 = CalculateFunctionWithTernary(x);
            Console.WriteLine($"Результат с использованием условного оператора: {result1}");
            Console.WriteLine($"Результат с использованием тернарной операции: {result2}");
        }
        static double CalculateFunctionWithIf(int x)
        {
            double y;
            if (x > 0)
            {
                y = 2 * Math.Pow(Math.Sin(x), 2);
            }
            else
            {
                y = 1 - 2 * Math.Pow(Math.Sin(x), 2);
            }
            return y;
        }
        static double
            CalculateFunctionWithTernary(int x)
        {
            double y = x > 0 ? 2 * Math.Pow(Math.Sin(x), 2) : 1 - 2 * Math.Pow(Math.Sin(x), 2);
            return y;
            ///z2
            // Генерируем случайное двузначное число
            Random random = new Random();
            int randomNumber = random.Next(10, 100);

            // Определяем четность числа с использованием тернарной операции
            string result = (randomNumber % 2 == 0) ? "Четное" : "Нечетное";

            // Выводим информацию на экран
            Console.WriteLine($"Случайное число: {randomNumber}");
            Console.WriteLine($"Четность числа: {result}");
            //z3
            // Вводим три целых положительных числа
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int num3 = int.Parse(Console.ReadLine());

            // Проверяем условия и обрабатываем числа соответственно
            if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0)
            {
                // Все числа четные, увеличиваем каждое на 1
                num1++;
                num2++;
                num3++;
            }
            else if (num1 % 2 == 0 || num2 % 2 == 0 || num3 % 2 == 0)
            {
                // Хотя бы одно число четное, уменьшаем каждое на 1
                num1--;
                num2--;
                num3--;
            }
            else
            {
                // Нет четных чисел, увеличиваем каждое в 2 раза
                num1 *= 2;
                num2 *= 2;
                num3 *= 2;
            }

            // Выводим результат на экран
            Console.WriteLine($"Результат: {num1}, {num2}, {num3}");
            ///z4
            Console.Write("Введите номер месяца (от 1 до 12): ");
            int monthNumber = int.Parse(Console.ReadLine());

            // Проверяем, что введенный номер месяца находится в диапазоне от 1 до 12
            if (monthNumber >= 1 && monthNumber <= 12)
            {
                string season;
                string message;

                // Определяем пору года
                switch (monthNumber)
                {
                    case 12:
                    case 1:
                    case 2:
                        season = "зима";
                        break;

                    case 3:
                    case 4:
                    case 5:
                        season = "весна";
                        break;

                    case 6:
                    case 7:
                    case 8:
                        season = "лето";
                        break;

                    case 9:
                    case 10:
                    case 11:
                        season = "осень";
                        break;

                    default:
                        season = "некорректный месяц";
                        break;
                }

                // Определяем сообщение
                if (monthNumber >= 1 && monthNumber <= 4)
                {
                    message = "каникулы";
                }
                else if (monthNumber >= 5 && monthNumber <= 8)
                {
                    message = "1 семестр";
                }
                else
                {
                    message = "2 семестр";
                }

                // Выводим результат
                Console.WriteLine($"Пора года: {season}");
                Console.WriteLine($"Сообщение: {message}");
            }
            else
            {
                Console.WriteLine("Некорректный номер месяца. Введите число от 1 до 12.");
            }



        }
    }
}
