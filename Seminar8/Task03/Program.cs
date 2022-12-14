// Задача 59: Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.
using MyLib;
using System;
using static System.Console;
Clear();
WriteLine("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);
int[,] array = MyExample.GetMatrixArray(rows, columns, 1, 9);
MyExample.PrintMatrix(array);
WriteLine();
WriteLine($"Минимальный элемент находиться -> {String.Join(" ", GetIndexMinEl(array))}");
WriteLine();
int[] indexes = GetIndexMinEl(array);
MyExample.PrintMatrix(GetResultArray(array, indexes));

int[] GetIndexMinEl(int[,] inArray)
{
    int[] result = new int[] { 0, 0 };
    int min = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (min > inArray[i, j])
            {
                min = inArray[i, j];
                result[0] = i;
                result[1] = j;

            }
        }
    }
    return result;
}

int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[row, column] = inArray[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return result;
}
