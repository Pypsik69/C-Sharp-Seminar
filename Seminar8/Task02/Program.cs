// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
using MyLib;
using System;
using static System.Console;
Clear();
Write("Введите размер матрицы через пробел: ");
int[] input = MyExample.GetArrayFromString(ReadLine()!);
int[,] array = MyExample.GetMatrixArray(input[0], input[1], input[2], input[3]);
MyExample.PrintMatrix(array);
WriteLine();
int[] newarray = LineArray(array);
MyExample.PrintArray(newarray);
WriteLine();
FreqInt(newarray);

int[] LineArray(int[,] arr)
{
    int[] linearr = new int[arr.GetLength(0) * arr.GetLength(1)];
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            linearr[k] = arr[i, j];
            k++;
        }
    }
    Array.Sort(linearr);
    return linearr;
}

void FreqInt(int[] array)
{
    int tmp = array[0];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == tmp)
        {
            k++;
        }
        else
        {
            WriteLine($"freq of {tmp} is {k}");
            k = 1;
            tmp = array[i];
        }
    }
    WriteLine($"freq of {tmp} is {k}");
}