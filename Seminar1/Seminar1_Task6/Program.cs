// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
// using static System.Console;

// Clear();
// int number = new Random().Next(100, 1000);
// WriteLine(number);
// int a0 = number%10;
// //int a1 = number/10;
// int a2 = number/100;
// int result = a2*10+a0;

// //WriteLine($"{a2} {a0}");
// WriteLine(result);

/////////////////////////////////////////////////////////////////////////////////////////////
// Разворот трёхзначного числа 
// using static System.Console;

// Clear();
// int number = new Random().Next(100,1000);
// WriteLine(number);

// int a0 = number%10;
// int a2 = number/100;
// int a1 = (number-(a2*100+a0));


// int result = a0*100+a1+a2;

// //WriteLine($"{a2}{a0}");
// WriteLine(result);
/////////////////////////////////////////////////////////////////////////////
// 
using static System.Console;

Clear();
//Write("Введите число: ");
int number = int.Parse(ReadLine()!);
string result=string.Empty;
while(number>0)
{
result+=number%10;
number/=10;
}
int newNumber=int.Parse(result);
WriteLine(newNumber);