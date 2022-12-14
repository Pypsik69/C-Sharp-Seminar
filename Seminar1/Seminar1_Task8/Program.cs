//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
using static System.Console;

Clear();
WriteLine("Введи число: ");
int number1 = int.Parse(ReadLine()!);

if (number1 == 0)
{
WriteLine(" Просто чтобы ты не баловался");
return;
}

int div1 = number1 % 7;
int div2 = number1 % 23;

if (div1 == 0 && div2 == 0)
{
WriteLine($"{number1} кратно 7 и 23");
}
else
{
WriteLine($"Число {number1} не кратно 7 и 23");
}