// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
using static System.Console;
Clear();
Write("Введите число N: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите число M: ");
int number2 = int.Parse(ReadLine()!);
int result = PowerNM(number1, number2);
WriteLine(result);

int PowerNM(int n, int m)
{
    return (m == 0) ? 1 : PowerNM(n, m - 1) * n;
}

///// проверка 
