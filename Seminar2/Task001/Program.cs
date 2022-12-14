using static System.Console;
Clear();
Write("Введите номер четверти: ");
int num = int.Parse(ReadLine()!);
switch (num)
{
    case 1:
        {
            WriteLine("X>0 Y>0");
            break;
        }
    case 2:
        {
            WriteLine("X<0 Y>0");
            break;
        }
    case 3:
        {
            WriteLine("X<0 Y<0");
            break;
        }
    case 4:
        {
            WriteLine("X>0 Y<0");
            break;
        }
    default:
        {
            WriteLine("Error");
            break;
        }
}