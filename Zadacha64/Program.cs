/* Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */

void PlusFunt(int m, int n, int sum = 0)
{
    if (m == n)
    {
        Console.Write(sum + n);
        return;
    }
    PlusFunt(m + 1, n, sum + m);
}
PlusFunt(4, 8);