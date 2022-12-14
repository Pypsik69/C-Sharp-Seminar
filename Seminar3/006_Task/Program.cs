// **Задача 37:** Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
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
WriteLine($"[{String.Join(",", MultElement(array))}]");
MultiplyNumbers(array);




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

int[] MultElement(int[] array)
{
    int len = array.Length;
    int size = len / 2 + len % 2;
    int[] multarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != len - 1 - i)
        {
            multarray[i] = array[i] * array[len - 1 - i];
        }
        else { multarray[i] = array[i]; }
    }
    return multarray;
}


void MultiplyNumbers(int[] ourArray)
{
    int arrayLength = (ourArray.Length % 2 == 0) ? ourArray.Length / 2 : ourArray.Length / 2 + 1;
    int[] newArray = new int[arrayLength];
    for (int i = 0; i < (ourArray.Length / 2); i++)
    {
        int multy = ourArray[i] * ourArray[(ourArray.Length - 1) - i];
        newArray[i] = multy;
    }
    if (ourArray.Length % 2 != 0)
    {
        newArray[arrayLength - 1] = ourArray[ourArray.Length / 2];
    }
    string strArray = string.Join(",", array);
    WriteLine($"[{strArray}]");
}

