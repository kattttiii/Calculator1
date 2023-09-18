using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие: \n1. Сложить 2 числа\n2. Вычесть первое из второго\n3. Перемножить два числа\n4. Разделить первое на второе\n5. Возвести в степень N первое число\n6. Найти квадратный корень из числа\n7. Найти 1 процент от числа\n8. Найти факториал из числа\n9. Выйти из программы");


            while (true)
            {
                Console.WriteLine("Введите номер операции");
                int number = int.Parse(Console.ReadLine());
                double num1, num2, result;
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Введите 1 число");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 + num2;
                        Console.WriteLine("Сумма этих чисел: " + result);
                        break;
                    case 2:
                        Console.WriteLine("Введите 1 число");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine("Разность этих чисел: " + result);
                        break;
                    case 3:
                        Console.WriteLine("Введите 1 число");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine("Произведение этих чисел: " + result);
                        break;
                    case 4:
                        Console.WriteLine("Введите 1 число");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 / num2;
                        Console.WriteLine("Частное этих чисел: " + result);
                        break; 
                    case 5:
                        Console.WriteLine("Введите число");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите степень");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1;
                        for (int i = 1; i < num2; i++)
                        {
                            result *= num1;
                        }
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 6:
                        Console.WriteLine("Введите число");
                        num1 = double.Parse(Console.ReadLine());
                        result = Math.Sqrt(num1);
                        Console.WriteLine("Корень из числа: " + result);
                        break;
                     case 7:
                        Console.WriteLine("Введите число");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("1% от числа: " + num1 / 100.0);
                        break;
                     case 8:
                        Console.WriteLine("Введите число");
                        num1 = double.Parse(Console.ReadLine());
                        result = 1;
                        for (int i = 2; i <= num1; i++)
                        {
                            result *= i;
                        }
                        Console.WriteLine("Факторил числа: " + result);
                        break;
                    case 9:
                        Console.WriteLine("Выход из программы");
                        break;
                    default:
                        Console.WriteLine("Некорректная операция.");
                        break;
                }
            }
        }
    }
}
