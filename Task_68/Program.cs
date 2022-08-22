// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if ((m != 0) && (n == 0))
    {
        return AckermannFunction(m - 1, 1);
    }
    else return (AckermannFunction(m - 1, AckermannFunction(m, n - 1)));
}

Console.WriteLine("Введите первое неотрицательное число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nВведите второе неотрицательное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n}: {AckermannFunction(m, n)}");
Console.WriteLine();