// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine(PrintNumbers(5));

string PrintNumbers(int m)
{
    if (m == 1)
    {
        return m.ToString();
    }
    return (m + ", " + PrintNumbers(m - 1));
}
