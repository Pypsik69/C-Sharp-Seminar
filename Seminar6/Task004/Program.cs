// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
using static System.Console;
Clear();
Write("Введите число: ");
int x = Convert.ToInt32(ReadLine()!);
int[] array = Fibinacci(new int[x]);
WriteLine($"[{String.Join("," , array)}]");

int[] Fibinacci(int[] number)
{
    number[0] = 0;
    number[1] = 1;
    for (int i = 2; i < number.Length; i++)
    {
        number[i] = number[i - 1] + number[i - 2];
    }
    return number;
}