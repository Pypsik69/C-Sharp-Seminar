// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
using static System.Console;
Clear();
Write("Enter the length of the array: ");
int length = int.Parse(ReadLine()!);
Write("Enter the min value of the array: ");
int min = int.Parse(ReadLine()!);
Write("Enter the max value of the array: ");
int max = int.Parse(ReadLine()!);
int[] array = GetArray(length, min, max);
string strArray = String.Join(",", array);
WriteLine($"[{strArray}]");
Write("Find number: ");
int find = int.Parse(ReadLine()!);
FindNumber2(array, find);



int[] GetArray(int size, int minValie, int maxValie)
{
    Random rnd = new Random(); // переменная генератор случайных чисел
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValie, maxValie + 1);
    }
    return result;
}

void FindNumber(int[] ourArray, int ourNumber)
{
    for (int i = 0; i < ourArray.Length; i++)
    {
        if (ourArray[i] == ourNumber)
        {
            Write("Yes");
            return;
        }
    }
    Write("NO ");
}

void FindNumber2(int[] ourArray, int ourNumber)
{
    foreach (var item in ourArray)
    {
        if (item == ourNumber)
        {
            WriteLine("yes");
            return;
        }
    }
    WriteLine("no");
}
