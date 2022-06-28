// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Эта программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine("Введите цифру и нажмите Enter");
int value = Convert.ToInt32(Console.ReadLine());

switch (value)
{
    case < 1:
    case > 7: Console.WriteLine("Нет такого дня"); break;

    case 6:
    case 7: Console.WriteLine("Да"); break;
    default: Console.WriteLine("Нет"); break;
}