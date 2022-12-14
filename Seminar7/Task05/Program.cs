// See https://aka.ms/new-console-template for more information
using static System.Console;
Clear();

int count = 0;
// do
// {
//     Write("Введите число: ");
//     if (int.Parse(ReadLine()!) > 0) count++;
//     WriteLine($"Positive numbers = {count}");
//     WriteLine("Continue? Yes - Enter, NO - n");
// } while (!(ReadLine()!.Equals("n"))); //Equals - эквивалентно . ! - перед проверкой условия, инвертирует
do
{
    Write("Введите число: ");
    if (int.Parse(ReadLine()!) > 0) count++;
    WriteLine($"Positive numbers = {count}");
    WriteLine("Continue? Yes - Enter, NO - any key");
} while (ReadKey().Key == ConsoleKey.Enter);