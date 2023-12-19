/*Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию,
не использовать циклы.
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 */

int[] CreateArrayRandom(int size)
{
    int[] array = new int[size];
    Console.Write("["); // форматируем вывод (начало массива)
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write(array[i] + " ");
    }
    Console.Write("]"); // форматируем вывод (конец массива)
    return array;
}
void PrintArray(int[] ar, int startIndex)
{
    if (startIndex <= ar.Length - 1)
    {
        PrintArray(ar, startIndex + 1);
        Console.Write(ar[startIndex] + " ");
    }
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRandom(size);
Console.Write(" => "); // форматируем вывод ( переход к результату)
PrintArray(array, 0); // передаем массив и позицию первого элемента


