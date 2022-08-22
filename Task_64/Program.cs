// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();

string PrintNumbersRange (int start, int end)
{
    if (start == end) return start.ToString();
    return ($"{start}, {PrintNumbersRange(start+1, end)}");
}

Console.WriteLine("Введите начало диапазона");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nВведите конец диапазона");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Диапазон чисел от {M} до {N}: ({PrintNumbersRange (M, N)})");
Console.WriteLine();