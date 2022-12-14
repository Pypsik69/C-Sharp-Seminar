// **Задача 48:** Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
using static System.Console;
Clear();
WriteLine("Введите размер матрицы через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1]);
PrintMatrix(matrix);

// int[,] matrix = GetMatrixArray2(3, 4);
// PrintMatrix(matrix);
WriteLine();
PrintMatrix(ReverseArray(matrix));





int[,] GetMatrixArray(int rows, int columns) // метод получения матриццы
{
    int[,] resultMatrix = new int[rows, columns];   //  rows строки → || columns - столбцы ↓
    for (int i = 0; i < resultMatrix.GetLength(0); i++) // resultMatrix.GetLength(1) - rows. Находиться тут - int[rows,] GetMatrixArray()
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++) // resultMatrix.GetLength(1) - columns. Находиться тут - int[,columns] GetMatrixArray
        {
            resultMatrix[i, j] = i + j;
        }
    }
    return resultMatrix;
}

int[,] ReverseArray(int[,] inArray)  // разворот действующей матрицы
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[i, j] = inArray[inArray.GetLength(0) - 1 - i, inArray.GetLength(1) - 1 - j];
        }
    }
    return result;
}


void PrintMatrix(int[,] inMatrix) // метод печати матрицы
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]} "); // \t - табуляция для выравнивания, особенно удобно использовать когда числа разные.
        }
        WriteLine();
    }
}

int[] GetArrayFromString(string parameters) // из строки возвращает в числовом виде количество строк и столбцов
{
    string[] parames = parameters.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}
// int[,] GetMatrixArray2(int rows, int columns)
// {
//     int[,] resultMatrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             resultMatrix[i, j] = i + j;
//         }
//     }
//     return resultMatrix;
// }

