// **Задача 53:** Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2
using MyLib;
using static System.Console;
Clear();
Write("Введите размер матрицы через пробел: ");
int[] input = MyExample.GetArrayFromString(ReadLine()!);
int[,] array = MyExample.GetMatrixArray(input[0], input[1], input[2], input[3]);
MyExample.PrintMatrix(array);
WriteLine();
ReplaceRows1toEnd(array);
MyExample.PrintMatrix(array);


void ReplaceRows1toEnd(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = temp;
    }
}



