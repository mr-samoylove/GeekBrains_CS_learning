// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Эта программа принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Введите первое число и нажмите Enter");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число и нажмите Enter");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число и нажмите Enter");
int third = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("наибольшее число = " + (first > second ?
                                          (first > third ? first : third) :
                                          (second > third ? second : third)));
