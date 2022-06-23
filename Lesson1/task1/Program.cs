
// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Эта программа проверяет, является ли первое число квадратом второго.\nВведите первое число и нажмите Enter");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число и нажмите Enter");
int second = Convert.ToInt32(Console.ReadLine());

if (second * second == first)
{
    Console.WriteLine($"Да, первое число - это квадрат второго: {second} * {second} = {first}");
}
else
{
    Console.WriteLine($"Нет, первое число не является квадратом второго: {second} * {second} != {first}");
}