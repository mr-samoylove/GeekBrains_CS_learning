﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] ArrayInit(uint length, int minRange = Int32.MinValue, int maxRange = Int32.MaxValue)
{
    Random rnd = new Random();
    double[] array = new double[length];

    for (int i = 0; i < length; i++)
        array[i] = rnd.Next(minRange, maxRange) + rnd.NextDouble();  // например если от 0 до 2 то [0.00 1.99]

    return array;
}

void ArrayPrinter(double[] array, int round = 6)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], round));
        Console.Write(i == array.Length - 1 ? "]\n" : " ");
    }
}

Console.WriteLine("Эта программа задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("На сколько элементов задать массив?");
uint n = Convert.ToUInt32(Console.ReadLine());

int from = 0; // можно дать пользователю ввести, например
int to = 10;
double[] array = ArrayInit(n, from, to); // диапазон задается вторым и третьим параметрами (необязательные параметры)

int round = 3;   // до скольки знаков после запятой округлить
ArrayPrinter(array, round);  // округление - второй необязательный параметр. по дефолту 6 знаков

double result = Math.Round(array.Max() - array.Min(), round);

Console.WriteLine($"max - min = {result}");