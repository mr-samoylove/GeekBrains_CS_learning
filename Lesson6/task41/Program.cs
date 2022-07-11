// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Эта программа считает, сколько чисел больше 0 ввёл пользователь.");
Console.Write("Сколько чисел вы хотите ввести? ");
uint n = Convert.ToUInt32(Console.ReadLine());

uint counter = 0;
int value = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write($"Введите {i}-е число: ");
    value = Convert.ToInt32(Console.ReadLine());
    if (value > 0) counter++;
}

Console.WriteLine($"Количество чисел больше нуля = {counter}");