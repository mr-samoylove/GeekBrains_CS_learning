// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void PrintSegment(int m, int n)
{
    Console.Write("Натуральные числа в диапазоне от M до N включительно: ");
    while (m <= n) Console.Write(m++ + " ");
}

Console.WriteLine("Эта программа задаёт значения M и N и выводит все натуральные числа в промежутке от M до N включительно.");
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) Console.WriteLine("Число M (от) должно быть меньше или равно N (до)");
else PrintSegment(m, n);