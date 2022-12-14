using static System.Console;
Clear();
Write("Введите строки через пробел или через(.,): ");
string[] words = ReadLine()!.Split(' ', '.', ',');
WriteLine($"[{String.Join(",", words)}]");
Method2(words);

void Method2(string[] word)
{
    int max = 3;
    for (int i = 0; i < word.Length; i++)
    {
        if (max < word[i].Length)
        {
            word[i] = string.Empty; 
        }
    }
    WriteLine($"[{String.Join(",", word)}]");
}


// void Method2(string[] par)
// {
//     string[] text;
//     text = par;
//     int max = 3;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (max < text[i].Length)
//         {
//             text[i] = string.Empty;
//         }
//     }
//     WriteLine($"[{String.Join(",", par)}]");
// }

