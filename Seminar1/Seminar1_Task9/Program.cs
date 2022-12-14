// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
using static System.Console;

Clear();
WriteLine("Введи число: ");
int number1 = int.Parse(ReadLine()!);
int number2 = int.Parse(ReadLine()!);

if (number1 == 0)
{
WriteLine("0 - не квадрат никакого числа");
return;
}

if (number1 == 2)
{
WriteLine("0 - не квадрат никакого числа");
return;
}


if (number2>number1)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}

int sqr = number2*number2;

if(sqr == number1)
{
WriteLine($"Число {number2} квадрат числа {number1}");
}
else
{
    WriteLine($"Число {number2}  не квадрат числа {number1}");
}