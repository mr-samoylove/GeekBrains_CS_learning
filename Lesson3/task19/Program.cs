// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Эта программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Введите число и нажмите Enter");
int value = Convert.ToInt32(Console.ReadLine());

if (value / 100000 == 0 && value / 10000 != 0)
{
    int lastTwoDigitsReversed = value % 100 / 10 + value % 10 * 10;   // смотрит 2 правые цифры и меняет их местами

    if (value / 1000 == lastTwoDigitsReversed) // сравнивает с левыми двумя числами
        Console.WriteLine("Да, это число - палиндром");
    else
        Console.WriteLine("Нет, это число - не палиндром");
}
else
{
    Console.WriteLine("Это не пятизначное число");
}