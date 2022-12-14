// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
using static System.Console;
Clear();
Write ("Введите число: ");
int A = int.Parse(ReadLine()!);
int sum = GetSum(A);
WriteLine($"Сумма чисел от 1 до А: {sum}");
WriteLine($"Сумма чисел от 1 до А: {GetSum1(A)}");



int GetSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result+=number;
        number--;
    }
    return result;
}

int GetSum1(int number)
{
    int result = 0;
    for (int i =1; i<=number; i++)
    {
        result+=i;
    }
    return result;
}