﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine(Akkerman(2, 3));
long Akkerman(long m, long n)
{
    if (m > 0)
        if (n > 0)
            return Akkerman(m - 1, Akkerman(m, n - 1));
        else
            return Akkerman(m - 1, 1);
    else
        return n + 1;
}

