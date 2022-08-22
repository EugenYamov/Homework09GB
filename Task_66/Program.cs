// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int PrintSummNumbersRange (int start, int end)
{
    if (start == end) return start;
    return (start + PrintSummNumbersRange(start+1, end));
}

Console.WriteLine("Введите начало диапазона");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nВведите конец диапазона");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Сумма элементов от {M} до {N}: ({PrintSummNumbersRange (M, N)})");
Console.WriteLine();