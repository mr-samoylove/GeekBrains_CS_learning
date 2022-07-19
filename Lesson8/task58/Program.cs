// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrixInit(uint m, uint n, int minRange = 0, int maxRange = 10)
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

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rowsOf1 = matrix1.GetLength(0);
    int rowsOf2 = matrix2.GetLength(0);
    int columnsOf1 = matrix1.GetLength(1);
    int columnsOf2 = matrix2.GetLength(1);

    int[,] m = new int[rowsOf1, columnsOf2];
    for (int i = 0; i < rowsOf1; i++)
    {
        for (int j = 0; j < columnsOf2; j++)
        {
            m[i, j] = 0;
            for (int k = 0; k < rowsOf2; k++)
            {
                m[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return m;
}

Console.WriteLine("Эта программа задает 2 матрицы и перемножает их.");
uint rows1 = 4;
uint columns1 = 2;
int[,] matrix1 = MatrixInit(rows1, columns1);
Console.WriteLine($"\nВот первая сгенерированная матрица {rows1}x{columns1}:");
PrintMatrix(matrix1);

uint rows2 = 2;
uint columns2 = 3;
int[,] matrix2 = MatrixInit(rows2, columns2);
Console.WriteLine($"\nВот вторая сгенерированная матрица {rows2}x{columns2}:");
PrintMatrix(matrix2);

if (columns1 == rows2)
{
    int[,] resultOfMultiplication = MultiplyMatrices(matrix1, matrix2);
    Console.WriteLine("\nВот результат умножения первой на вторую:");
    PrintMatrix(resultOfMultiplication);
}
else
{
    Console.WriteLine("\nКол-во столбцов первой матрицы не равно кол-ву строк второй. Умножение невозможно.");

}
