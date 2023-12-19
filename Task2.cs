/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29  */

int AkkermanFunction(int m, int n)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
    {
        return AkkermanFunction(n - 1, 1);
    }
    else
    {
        return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
    }
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.Write("Введите другие числа!");
}
else
{
    Console.Write($"m={m}; n={n} -> A(m,n)=");
    Console.WriteLine(AkkermanFunction(m, n));
}
