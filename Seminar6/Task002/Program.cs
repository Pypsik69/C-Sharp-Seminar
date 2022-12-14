// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
using static System.Console;
Clear();
Write("Введите стороны треугольника");
int a = Convert.ToInt32(ReadLine()!);
int b = Convert.ToInt32(ReadLine()!);
int c = Convert.ToInt32(ReadLine()!);
CheckTriangle(a,b,c);



void CheckTriangle(int aa, int bb, int cc)
{
    if (aa + bb > cc && aa + cc > bb && bb + cc > aa)
    {
        WriteLine("Существует");
    }
    else WriteLine("не Существует");
}