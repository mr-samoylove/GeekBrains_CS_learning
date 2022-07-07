// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] ArrayInit(uint length, int minRange = Int32.MinValue, int maxRange = Int32.MaxValue)
{
    Random rnd = new Random();
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
        array[i] = rnd.Next(minRange, maxRange);

    return array;
}

void ArrayPrinter(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(i == array.Length - 1 ? "]\n" : " ");
    }
}

uint SumOfEvenNumbers(int[] array)
{
    uint result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

Console.WriteLine("Эта программа задаёт массив заполненный случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве.");
Console.WriteLine("На сколько элементов задать массив?");
uint n = Convert.ToUInt32(Console.ReadLine());

int[] array = ArrayInit(n, -999, 1000);
ArrayPrinter(array);
uint result = SumOfEvenNumbers(array);
Console.WriteLine($"Количество четных элементов = {result}");