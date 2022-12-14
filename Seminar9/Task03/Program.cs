// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
using static System.Console;
Clear();
Write("Введите число N: ");
int number1 = int.Parse(ReadLine()!);
// Write("Введите число M: ");
// int number2 = int.Parse(ReadLine()!);
Write(SumOfNumbers(number1));

int SumOfDigits(int n)
{
    return (n / 10 == 0) ? n % 10 : SumOfDigits((n) / 10) + n % 10;
}

int SumOfNumbers(int n)
{
    if (n == 0) return 0;
    else
    {
        return n % 10 + SumOfNumbers(n / 10);
    }
}







// string GetNumbersNM(int n, int m)
// {
//     return (n == m) ? n.ToString() : GetNumbersNM(n - 1, m) + " " + n;
// }


// string GetNumbers(int n)
// {
//     if (n == 1) return n.ToString();
//     else return GetNumbers(n - 1) + " " + n;
// }


// void GetNumbers1(int n)
// {
//     if (n == 1) Write(n);
//     else
//     {
//         GetNumbers1(n - 1);
//         Write(" " + n);
//     }
// }

// string GetNumbers2(int n)
// {
//     return (n == 1) ? n.ToString() : GetNumbers(n - 1) + " " + n;
// }