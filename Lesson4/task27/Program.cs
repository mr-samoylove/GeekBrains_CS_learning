// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int a)
{
    int sum = 0;
    while (a != 0)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum >= 0 ? sum : -sum;
}

Console.WriteLine("Эта программа принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат: " + SumOfDigits(value));
