// **Задача 31:** Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
using static System.Console;
Clear();
Write("Введите длину массива: ");
int size = int.Parse(ReadLine()!);
Write("Введите мин значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите макс значение массива: ");
int max = int.Parse(ReadLine()!);
int[] array = GetArray(size, min, max);
string strArray = String.Join(",", array); // String.Join - разделитель массива, то что указано в ковычках, будет выведен на терминал между элементами массива 
WriteLine($"[{strArray}]");
//WriteLine($"[{String.Join(",", array)}]"); // можно и так оформить не добавляя лишние переменные 
int negativesum = 0;
int positivesum = 0;

foreach (int element in array) // foreach - от нуля до конца, как раз нужен для того чтобы считать весь массив
{
    // positivesum += element > 0 ? element : 0; //
    // negativesum += element < 0 ? element : 0; // Вариант решения с помощью Тернарного оператора
    if (element > 0)
    {
        positivesum += element;
    }
    if (element < 0)
    {
        negativesum += element;
    }
}

WriteLine($"Cумма отрицательных равна = {negativesum}, cумма положительных чисел равна = {positivesum}");


int[] GetArray(int size, int minValie, int maxValie)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValie, maxValie + 1);
    }
    return result;
}