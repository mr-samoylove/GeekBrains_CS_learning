// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

Console.WriteLine("Эта программа задает двумерный массив 4x4 и заполняет его спирально.");
int[,] matrix = { {  1,  2,  3, 4 },
                  { 12, 13, 14, 5 },
                  { 11, 16, 15, 6 },
                  { 10,  9,  8, 7 } };
PrintMatrix(matrix);