// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Эта программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите число N");
int value = Convert.ToInt32(Console.ReadLine());

if (value > 0)
{
    Console.Write($"{value} -> 1"); // единица пишется всегда один раз

    for (int counter = 2; counter <= value; counter++)
        Console.Write(", " + Math.Pow(counter, 3)); // пишется запятая, пробел и число в каждой итерации
}
else
{
    Console.WriteLine("Так не бывает, нужно число более или равное 1");
}