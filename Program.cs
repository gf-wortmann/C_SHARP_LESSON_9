﻿//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


int AckermanFunction( int M, int N)
{
    if (M == 0)                     return N + 1;
    else if ((M > 0) && (N == 0))   return AckermanFunction ( M - 1, 1 );
    else if ((M > 0) && (N > 0))    return AckermanFunction ( M - 1, AckermanFunction ( M, N - 1 ));
    else                            return N + 1;
}

Console.WriteLine ($" Ackerman Function A(2, 3) is: {AckermanFunction (2, 3)}");
Console.WriteLine ($" Ackerman Function A(3, 2) is: {AckermanFunction (3, 2)}");
Console.WriteLine ($" Ackerman Function A(3, 3) is: {AckermanFunction (3, 3)}");
Console.WriteLine ($" Ackerman Function A(3, 4) is: {AckermanFunction (3, 4)}");