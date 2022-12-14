// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
using static System.Console;
Clear();
int[] array = PrepareArray();
int[] result = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    result[i] = array[i];
}
WriteLine($"[{String.Join(", ", array)}]");
int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}



int[] PrepareArray()
{
    Write(" array size, min, max: ");
    string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] arr = GetArray(Convert.ToInt32(parameters[0]), Convert.ToInt32(parameters[1]), Convert.ToInt32(parameters[2]));
    WriteLine($"[{String.Join(", ", arr)}]");
    return arr;
}