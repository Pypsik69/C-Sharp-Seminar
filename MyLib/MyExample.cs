using System;
using static System.Console;
namespace MyLib;
public class MyExample
{
    /// <summary>
    /// Метод получения одномерного массива. Размер, мин и макс значение
    /// </summary>
    public static int[] GetArray(int size, int minValie, int maxValie)
    {
        int[] result = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {
            result[i] = rnd.Next(minValie, maxValie);
        }
        return result;
    }

    /// <summary>
    /// Разворот массива
    /// </summary>
    public static int[] ReverseArray(int[] inArray)
    {
        int[] result = new int[inArray.Length];
        for (int i = 0; i < inArray.Length; i++)
        {
            result[i] = inArray[inArray.Length - 1 - i];
        }
        return result;
    }
    /// <summary>
    /// Разворот массива (Войд)
    /// </summary>
    public static void ReverseArray2(int[] inArray)
    {
        for (int i = 0; i < inArray.Length / 2; i++)
        {
            int temp = inArray[i];
            inArray[i] = inArray[inArray.Length - 1 - i];
            inArray[inArray.Length - 1 - i] = temp;
        }
    }

    ///<summary>
    /// из строки возвращает в числовом 
    ///</summary>
    public static int[] GetArrayFromString(string parameters)
    {
        string[] parames = parameters.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
        int[] parameterNum = new int[parames.Length];
        for (int i = 0; i < parameterNum.Length; i++)
        {
            parameterNum[i] = int.Parse(parames[i]);
        }
        return parameterNum;
    }

    ///<summary>
    /// метод получения матриццы в случайном порядке. (Строки, столбцы, мин и макс значение)
    ///</summary>
    public static int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue) // 
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

    ///<summary>
    /// метод печати матрицы
    ///</summary>
    public static void PrintMatrix(int[,] inMatrix)
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

    ///<summary>
    /// разворот действующей матрицы
    ///</summary>
    public static int[,] ReverseMatrixArray(int[,] inArray)  // 
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


    ///<summary>
    /// метод возведения в степень элементов у которых оба индекса чётные из действующей матрицы
    ///</summary>
    public static void EditMatrix(int[,] newMatrix)
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

    ///<summary>
    /// (матрица)сложение суммы на главной диогонали (0,0) (1,1) и т.д.
    ///</summary>
    public static int EditMatrix1(int[,] newMatrix)
    {
        int result = 0;
        int newI = newMatrix.GetLength(0) > newMatrix.GetLength(1) ? 1 : 0;  // тернарный оператор 
        for (int i = 0; i < newMatrix.GetLength(newI); i++)
        {
            result += newMatrix[i, i];
        }
        return result;
    }
    ///<summary>
    /// преобразовывает десятичное число в двоичное
    ///</summary>
    public static string delenie(int num)
    {
        if (num == 0)
        {
            return "0";
        }
        string result = string.Empty;
        while (num != 0)
        {
            result = (num % 2) + result;
            num = num / 2;

        }
        return result;
    }
    ///<summary>
    /// Фибаначчи
    ///</summary>
    public static int[] Fibinacci(int[] number)
    {
        number[0] = 0;
        number[1] = 1;
        for (int i = 2; i < number.Length; i++)
        {
            number[i] = number[i - 1] + number[i - 2];
        }
        return number;
    }

    public static void PrintArray(int[] inArray)
    {
        Write("[");
        for (int i = 0; i < inArray.Length - 1; i++) // (-1) нужен для того чтобы не печатать последний элемент (в конце цикла)
        {
            Write($"{inArray[i]},");
        }
        Write($"{inArray[inArray.Length - 1]}]");
    }

    ///<summary>
    /// Крутит матрицу по диагонали
    ///</summary>
    public static string TransponMatrix(int[,] arr) // 
    {
        if (arr.GetLength(0) != arr.GetLength(1))
        {
            return "couldn't do";
        }
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i + 1; j < arr.GetLength(1); j++)
            {
                int tmp = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = tmp;
            }
        }
        return "ready";
    }

    public static void ReplaceRows1toEnd(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            int temp = arr[0, i];
            arr[0, i] = arr[arr.GetLength(0) - 1, i];
            arr[arr.GetLength(0) - 1, i] = temp;
        }
    }

}