// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] MatrixInitDouble(uint m, uint n, int minRange = 0, int maxRange = 100)
{
    Random rnd = new Random();

    var matrix = new double[m, n];
    for (uint i = 0; i < m; i++)
    {
        for (uint j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.NextDouble() * (maxRange - minRange) + minRange;
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix, uint m, uint n, int round = 2)
{
    for (uint i = 0; i < m; i++)
    {
        for (uint j = 0; j < n; j++)
        {
            Console.Write(Math.Round(matrix[i, j], round) + "\t");
        }
        System.Console.WriteLine();
    }
}

Console.WriteLine("Эта программа задает двумерный массив размером mxn, заполненный случайными вещественными числами.");
Console.Write("Введите m(количество строк): ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите n(количество столбцов): ");
uint n = Convert.ToUInt32(Console.ReadLine());

double[,] matrix = MatrixInitDouble(m, n);
PrintMatrixDouble(matrix, m, n);