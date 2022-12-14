using static System.Console; //Позволяет не писать каждый раз команду Console

Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
int num2 = int.Parse(ReadLine()!); //Parse - это конвертация
int sqr1 = num1*num1;
int sqr2 = Convert.ToInt32(Math.Pow(num2,2));
WriteLine($"Квадрат числа {num1} = {sqr1}");
WriteLine($"Квадрат числа {num2} = {sqr2}");