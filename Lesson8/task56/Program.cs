// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (uint i = 0; i < rows; i++)
    {
        for (uint j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int FindRowWithMinimumSumOfElements(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int minimumSum = Int32.MaxValue;
    int result = 0;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minimumSum)
        {
            minimumSum = sum;
            result = i;
        }
    }
    return result;
}

Console.WriteLine("Эта программа задает двумерный массив и находит строку с наименьшей суммой элементов.");
uint rows = 5;
uint columns = 2;
int[,] matrix = MatrixInit(rows, columns);
Console.WriteLine($"Вот сгенерированная матрица {rows}x{columns}:");
PrintMatrix(matrix);

Console.WriteLine("Строка с наименьшей суммой элементов: " + FindRowWithMinimumSumOfElements(matrix) + " (отсчет ведется с нуля)");

