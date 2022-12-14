// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
using static System.Console;

Clear();
WriteLine("Введи первое число: ");
int number1 = int.Parse(ReadLine()!);
WriteLine("Введи второе число: ");
int number2 = int.Parse(ReadLine()!);

if (number2 == 0)
{
    WriteLine(" На 0 делить нельзя");
    return; //для досрочного завершения программы, чтобы дальше не проходился по нижним строкам
}

    int div = number1%number2;

if (div == 0)
{
    WriteLine($"{number1} кратно {number2}");
}
else
{
    WriteLine($"Остаток от деления {number1} на {number2}: {div}");
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// using static System.Console;
// Clear();

// Write("Введите число: ");
// int num1 = Convert.ToInt32(ReadLine()!);
// Write("Введите число: ");
// int num2 = Convert.ToInt32(ReadLine()!);
// if (num2 > num1)
// {
// int temp = num1;
// num1 = num2;
// num2 = temp;
// }


// if (num1 % num2 == 0)
// {
// WriteLine("Числа кратны ");
// }

// else
// {
// WriteLine($"Остаток от деления равен {num1 % num2}");
// }