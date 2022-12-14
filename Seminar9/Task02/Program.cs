// **Задача 65:** Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
using MyLib;
using System;
using static System.Console;
Clear();
Write("Введите число N: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите число M: ");
int number2 = int.Parse(ReadLine()!);
string result = GetNumbersNM2(number1, number2);
WriteLine(result);

string GetNumbersNM(int n, int m)
{
    return (n == m) ? n.ToString() : GetNumbersNM(n - 1, m) + " " + n;
}

string GetNumbersNM2(int n, int m)
{
    if (n == m)
    {
        return n.ToString();
    }
    return (n > m) ? GetNumbersNM2(n - 1, m) + " " + n : GetNumbersNM2(m - 1, n) + " " + m;
}






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




