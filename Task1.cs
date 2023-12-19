/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Использовать рекурсию, не использовать циклы.
M = 1; N = 5 -> "1, 2, 3, 4, 5"     M = 4; N = 8 -> "4, 5, 6, 7, 8"   */

void PrintNumbers(int m, int n)
{
    if (n >= m)
    {
        PrintNumbers(m, n - 1);
        Console.Write($"{n} ");
    }
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M <= 0 || N <= 0 || M > N)
{
    Console.Write("Введите другие числа!");
}
else
{
    Console.Write($"M={M}; N={N} -> ");
    PrintNumbers(M, N);
}
