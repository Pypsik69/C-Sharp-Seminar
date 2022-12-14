//Напишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"
using static System.Console;

Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
int num2=-num1;

while(num2<=num1)
{
Write($"{num2} ");
num2++;
}