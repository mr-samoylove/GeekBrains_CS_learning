// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintMeansInColumns(int[,] matrix, uint m, uint n)
{
    for (uint i = 0; i < n; i++) Console.Write(i + "\t");
    Console.WriteLine();

    double mean;
    for (uint i = 0; i < n; i++)
    {
        mean = 0;
        for (uint j = 0; j < m; j++)
        {
            mean += matrix[j, i];
        }
        Console.Write(Math.Round(mean / m, 1) + "\t");
    }
}


Console.WriteLine("Эта программа задает двумерный массив из целых чисел и находит среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Вот сгенерированная матрица:");
uint rows = 10;
uint columns = 10;
int[,] matrix = MatrixInit(rows, columns);
PrintMatrix(matrix, rows, columns);

Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
PrintMeansInColumns(matrix, rows, columns);
