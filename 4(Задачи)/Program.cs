using System;

class Program
{
    static void Main()
    {
        // Запрос первого числа
        Console.Write("Введите первое число: ");
        string input1 = Console.ReadLine();

        // Запрос второго числа
        Console.Write("Введите второе число: ");
        string input2 = Console.ReadLine();

        // Преобразование введенных данных в числа
        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            // Сравнение чисел
            if (number1 == number2)
            {
                Console.WriteLine("Числа равны.");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("Первое число больше второго.");
            }
            else
            {
                Console.WriteLine("Первое число меньше второго.");
            }
        }
        else
        {
            // Сообщение об ошибке при некорректном вводе
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите числа.");
        }
    }
}