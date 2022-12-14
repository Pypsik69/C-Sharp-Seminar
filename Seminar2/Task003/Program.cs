// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
using static System.Console;
Clear();
Write("Введите координату X первой точки: ");
int a1 = Convert.ToInt32(ReadLine()!);
Write("Введите координату Y первой точки: ");
int a2 = Convert.ToInt32(ReadLine()!);
Write("Введите координату X второй точки: ");
int b1 = Convert.ToInt32(ReadLine()!);
Write("Введите координату Y второй точки: ");
int b2 = Convert.ToInt32(ReadLine()!);
double length = Math.Sqrt(Math.Pow(a1-b1,2) + Math.Pow(a2-b2,2)); //Math.Pow для возведения в квадрат (a1-b1, 2) - результат умножаем на квадрат Math.Sqrt(пример) - вычисляет корень числа примера
WriteLine($"{length:f3}");