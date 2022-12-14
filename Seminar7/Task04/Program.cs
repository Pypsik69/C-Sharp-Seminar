// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
using static System.Console;
Clear();
WriteLine("Введите размер матрицы через пробел: ");
int[,] matrix = GetMatrixArray2(3, 4);
PrintMatrix(matrix);
WriteLine();
WriteLine(EditMatrix2(matrix));


void PrintMatrix(int[,] inMatrix) // метод печати матрицы
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
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

int[,] GetMatrixArray2(int rows, int columns) // метод получения матриццы в случайном порядке
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = new Random().Next(2, 9);
        }
    }
    return resultMatrix;
}

int EditMatrix(int[,] newMatrix) // сложение суммы на главной диогонали (0,0) (1,1) и т.д.
{
    int result = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (i == j)
            {
                result += newMatrix[i, j];
            }
        }
    }
    return result;
}

int EditMatrix2(int[,] newMatrix)  // сложение суммы на главной диогонали (0,0) (1,1) и т.д.
{
    int result = 0;
    int newI = newMatrix.GetLength(0) > newMatrix.GetLength(1) ? 1 : 0;  // тернарный оператор 
    for (int i = 0; i < newMatrix.GetLength(newI); i++)
    {
        result += newMatrix[i, i];
    }
    return result;
}