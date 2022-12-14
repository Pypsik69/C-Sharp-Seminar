// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
using static System.Console;
Clear();
Write ("Введите число: ");
int A = int.Parse(ReadLine()!);
int sum = GetFactor(A);
WriteLine($"Результат: {sum}");


int GetLen(int number)
{
    int result = 0;
    while (number > 0)
    {
        number /= 10;
        result++;
    }
    return result;
}

int GetFactor(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++){
        result *= i;
    }
    return result;
}