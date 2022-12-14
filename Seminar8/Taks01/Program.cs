// **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
using System;
using MyLib;
using static System.Console;
Clear();
Write("Введите размер матрицы через пробел: ");
int[] input = MyExample.GetArrayFromString(ReadLine()!);
int[,] array = MyExample.GetMatrixArray(input[0], input[1], input[2], input[3]);
MyExample.PrintMatrix(array);
WriteLine();
MyExample.PrintMatrix(TransponToNewMatrix(array));
// ReplaceRows1toEnd(array);

int[,] TransponToNewMatrix(int[,] arr) // 
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        WriteLine("Couldn't do");
        return arr;
    }
    int[,] newArray = new int[arr.GetLength(0), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArray[i, j] = arr[j, i];

        }
    }
    WriteLine("ready");
    return newArray;
}

