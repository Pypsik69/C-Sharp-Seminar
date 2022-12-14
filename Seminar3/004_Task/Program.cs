// **Задача 32:** Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
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
ReverseArray(array);






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

void ReverseArray(int[] ourArray)
{
    for (int i = 0; i < ourArray.Length; i++)
    {
        ourArray[i] = ourArray[i] * (-1);
    }
    WriteLine($"[{String.Join(",", ourArray)}]");
}

