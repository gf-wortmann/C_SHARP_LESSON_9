//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumbers (int N)
{
    //for (int i = 0; i < N; i++)
    //while (N > 0)
    if (N == 0) return;
    {
        Console.WriteLine($"{N}");
        NaturalNumbers (N-1);
        //return;
    }
    //return;
}

int N = 8;
int M = 5;

Console.WriteLine($"Numbers from {N} to 1");
NaturalNumbers (N);
Console.WriteLine($"\nNumbers from {M} to 1");
NaturalNumbers (M);