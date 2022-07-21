// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumWithinSegment(int m, int n)
{
    int result = 0;
    while (m <= n) result += m++;
    return result;
}

Console.WriteLine("Эта программа задаёт значения M и N и находит сумму натуральных элементов в промежутке от M до N включительно.");
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) Console.WriteLine("Число M (от) должно быть меньше или равно N (до)");
else Console.WriteLine("Сумма натуральных чисел в диапазоне от M до N включительно: " + SumWithinSegment(m, n));