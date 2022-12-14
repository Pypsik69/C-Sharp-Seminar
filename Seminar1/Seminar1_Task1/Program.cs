//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет
using static System.Console;

Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
int num2 = Convert.ToInt32(ReadLine());
if (num2 * num2 == num1)
{
    Write($"Число {num2} является квадратом числа {num1}");
}

else
{
    Write($"Число {num2} не является квадратом числа {num1}");
}