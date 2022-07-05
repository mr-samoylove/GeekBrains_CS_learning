// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PositiveExponent(int a, int b)
{
    int result = 1;
    while (b-- > 0) result *= a;

    return result;
}

Console.WriteLine("Эта программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Введите число A (основание степени)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B (показатель степени)");
int b = Convert.ToInt32(Console.ReadLine());

if (b < 0) Console.WriteLine("Эта программа работает только с натуральными степенями");
else Console.WriteLine("Результат: " + PositiveExponent(a, b));
