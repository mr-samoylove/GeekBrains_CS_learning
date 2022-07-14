// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] MatrixInit(uint m, uint n, int minRange = 0, int maxRange = 1000)
{
    Random rnd = new Random();

    var matrix = new int[m, n];
    for (uint i = 0; i < m; i++)
    {
        for (uint j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, uint m, uint n)
{
    for (uint i = 0; i < m; i++)
    {
        for (uint j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


Console.WriteLine("Эта программа на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Вот сгенерированная матрица:");
uint rows = 10;
uint columns = 10;
int[,] matrix = MatrixInit(rows, columns);
PrintMatrix(matrix, rows, columns);

Console.Write("\nВведите m (строку): ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите n (столбец): ");
uint n = Convert.ToUInt32(Console.ReadLine());

if (m >= rows || n >= columns) Console.WriteLine("Нет такого элемента.");
else Console.WriteLine("Искомый элемент: " + matrix[m, n]);
