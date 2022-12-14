//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNaturalNumbers (int M, int N)
{
    if (M <= N) return (SumNaturalNumbers (M+1, N) + M);
    else return 0;
}

Console.Clear();
int M1 = 1;
int N1 = 15;
Console.WriteLine($"\nSum of numbers from {M1} to {N1} is: {SumNaturalNumbers (M1, N1)}");

int M2 = 4;
int N2 = 8;
Console.WriteLine($"\nSum of numbers from {M2} to {N2} is: {SumNaturalNumbers (M2, N2)}");
