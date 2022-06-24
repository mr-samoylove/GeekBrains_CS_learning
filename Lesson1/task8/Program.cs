// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Эта программа принимает на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число и нажмите Enter");
int value = Convert.ToInt32(Console.ReadLine());

if (value <= 1)
{
    Console.WriteLine("Нет таких чисел");
}
else
{
    Console.Write("Результат: 2");
    for (int counter = 4; counter <= value; counter += 2)
        Console.Write($", {counter}");
}