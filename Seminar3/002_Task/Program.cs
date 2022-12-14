// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
using static System.Console;
Clear();
Write("Введите длину массива: ");
int size = int.Parse(ReadLine()!);
int[] array = GetBinaryArray(size);
PrintArray(array);
WriteLine();
WriteLine($"Количество нулей {CountZeros(array)}");
Write("Какую цифру нужно найти? Введите цифру: ");
int digit = int.Parse(ReadLine()!);
WriteLine($"Количество цифр по вашему поиску: {CountDigits(array, digit)}");



int[] GetBinaryArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++) // (-1) нужен для того чтобы не печатать последний элемент (в конце цикла)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}

int CountZeros(int[] InArray)
{
    int result = 0;
    for (int i = 0; i < InArray.Length; i++)
    {
        if (InArray[i] == 0)
        {
            result += 1;
        }
    }
    return result;
}

int CountDigits(int[] InArray, int number)
{
    int result = 0;
    for (int i = 0; i < InArray.Length; i++)
    {
        if (InArray[i] == number)
        {
            result += 1;
        }
    }
    return result;
}