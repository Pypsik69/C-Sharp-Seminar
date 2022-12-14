//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

using static System.Console;
Clear();
Write("Введите число дня недели: ");
int num1 = Convert.ToInt32(ReadLine());
if (num1 == 1)
{
    Write("1. Понедельник");
}
if (num1 == 2)
{
    Write("2. Вторник");
}
if (num1 == 3)
{
    Write("3. Среда");
}
if (num1 == 4)
{
    Write("4. Четверг");
}
if (num1 == 5)
{
    Write("5. Пятница");
}
if (num1 == 6)
{
    Write("6. Суббота");
}
if (num1 == 7)
{
    Write("7. Воскресенье");
}
if (num1 > 7 || num1 < 1)
{
    Write("Это не день недели");
}

WriteLine("Введите день недели от 1 до 7:");
int DayOfWeek = Convert.ToInt32(ReadLine());
string Day ="Неправильно ввели день недели";

if(DayOfWeek==1) Day= "Понедельник";
if(DayOfWeek==2) Day= "Вторник";
if(DayOfWeek==3) Day= "Среда";
if(DayOfWeek==4) Day= "Четверг";
if(DayOfWeek==5) Day= "Пятница";
if(DayOfWeek==6) Day= "суббота";
if(DayOfWeek==7) Day= "Воскресенье";


WriteLine(Day);