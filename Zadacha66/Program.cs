﻿/* Задача 66: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. */

// функция Аккермана

Console.WriteLine("Введите неотрицательно чило m: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите неотрицательно чило n: ");
int m = int.Parse(Console.ReadLine()!);

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else if 
  ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman((n - 1), Akkerman(n,( m - 1)));
}
Console.WriteLine($"A(m,n)= {Akkerman(n,m)}");