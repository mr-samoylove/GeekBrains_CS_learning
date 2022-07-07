// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfElsOnUnevenIndexes(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

Console.WriteLine("Эта программа задаёт одномерный массив, заполненный случайными числами, и находит сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("На сколько элементов задать массив?");
uint n = Convert.ToUInt32(Console.ReadLine());

int[] array = ArrayInit(n);   // можно задавать диапазон вторым и третьим параметрами
ArrayPrinter(array);
int result = SumOfElsOnUnevenIndexes(array);
Console.WriteLine($"Сумма элементов на нечетных позициях = {result}");