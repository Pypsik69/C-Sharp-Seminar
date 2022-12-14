//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
using static System.Console;
Clear();
Write("Введите число: ");
int a = Convert.ToInt32(ReadLine()!);
WriteLine(delenie(a));

Write("Способ конвертаций без методов, введи число чтобы убедиться: "); // Способ без метода
int num = int.Parse(ReadLine()!);
WriteLine(Convert.ToString(num, 2));


string delenie(int num)
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

string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        // res=nums[ost]+res;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}

// WriteLine("введите букву : ");    // про шахматную доску
// string str = ReadLine();
// WriteLine("введите цифру : ");
// int a = Convert.ToInt32(ReadLine()!);
// string letters = "abcdefgh";
// string result = "белая";
// if ((letters.IndexOf(str) + a) % 2 == 0)
// {
//     result = "черная";
// }
// WriteLine(result);

