// **Задача 39:** Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
using static System.Console;
Clear();
WriteLine("Введи размер массива, мин и макс значение через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries); //.Split(" ") Позволяет разбить вводимые данные на пробелы, одним словом разбивает строку на подстроки. StringSplitOptions.RemoveEmptyEntries - удаляет случайные пробелы 
int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
WriteLine($"[{String.Join(",", array)}]");
WriteLine($"[{String.Join(",", ReverseArray(array))}]");
ReverseArray2(array);
WriteLine($"[{String.Join(",", array)}]");
WriteLine($"[{String.Join(",", ReverseArray3(array))}]");




int[] GetArray(int size, int minValie, int maxValie)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValie, maxValie);
    }
    return result;
}

int[] ReverseArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}

int[] ReverseArray3(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
    return inArray;
}