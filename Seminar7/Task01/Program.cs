// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
using static System.Console;
Clear();
Write("Введите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);







int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue) // метод получения матриццы в случайном порядке
{
    int[,] resultMatrix = new int[rows, columns];   //  rows строки → || columns - столбцы ↓
    for (int i = 0; i < resultMatrix.GetLength(0); i++) // resultMatrix.GetLength(1) - rows. Находиться тут - int[rows,] GetMatrixArray()
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++) // resultMatrix.GetLength(1) - columns. Находиться тут - int[,columns] GetMatrixArray
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix) // метод печати матрицы
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]} ");
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