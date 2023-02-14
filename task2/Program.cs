// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine(PrintSumNumbers(1, 9));

int PrintSumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + PrintSumNumbers(m + 1, n);
}
