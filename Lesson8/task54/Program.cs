// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void MatrixSortNumbersInRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}



Console.WriteLine("Эта программа задает двумерный массив и упорядочивает по убыванию элементы каждой строки.");
uint rows = 5;
uint columns = 5;
int[,] matrix = MatrixInit(rows, columns);
Console.WriteLine($"Вот сгенерированная матрица {rows}x{columns}:");
PrintMatrix(matrix);

Console.WriteLine("После упорядочения:");
MatrixSortNumbersInRows(matrix);
PrintMatrix(matrix);
