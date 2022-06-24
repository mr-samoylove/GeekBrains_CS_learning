
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Эта программа находит наибольшее из двух чисел\nВведите первое число и нажмите Enter");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число и нажмите Enter");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Наибольшее число = " + (first > second ? first : second));
