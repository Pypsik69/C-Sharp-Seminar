// **Задача 49:** Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4
using static System.Console;
Clear();
WriteLine("Введите размер матрицы через пробел: ");
int[,] matrix = GetMatrixArray2(5, 5);
PrintMatrix(matrix);
WriteLine();
EditMatrix(matrix);
PrintMatrix(matrix);


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
            resultMatrix[i, j] = new Random().Next(5, 10);
        }
    }
    return resultMatrix;
}

void EditMatrix(int[,] newMatrix) //метод возведения в степень элементов у которых оба индекса чётные из действующей матрицы
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                newMatrix[i, j] = Convert.ToInt32(Math.Pow(newMatrix[i, j], 2)); //Math.Pow(эл, 2) возведение в степень
                //newMatrix[i, j] *= newMatrix[i, j];
            }
        }
    }
}
