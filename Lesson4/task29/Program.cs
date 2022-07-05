// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Arrayinitializer(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = rnd.Next();

    return array;
}

void ArrayPrinter(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(i == array.Length - 1 ? "]" : ", ");
    }
}

Console.WriteLine("Эта программа задаёт массив из 8 элементов и выводит их на экран.");
Console.WriteLine("В данной реализации числа в массиве сгенерированы пседослучайно.");

int[] array = Arrayinitializer(8);
ArrayPrinter(array);



