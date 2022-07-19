// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] MatrixInit3D(uint rows, uint columns, uint z)
{
    Random rnd = new Random();
    int value = 10;

    var matrix = new int[rows, columns, z];
    for (uint i = 0; i < rows; i++)
    {
        for (uint j = 0; j < columns; j++)
        {
            for (uint k = 0; k < z; k++)
            {
                matrix[i, j, k] = value++;
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int z = matrix.GetLength(2);
    for (uint i = 0; i < rows; i++)
    {
        for (uint j = 0; j < columns; j++)
        {
            for (uint k = 0; k < z; k++)
            {
                Console.Write(matrix[i, j, k] + $"({i}, {j}, {k})" + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

Console.WriteLine("Эта программа задает трёхмерный массив из неповторяющихся двузначных чисел и построчно выводит его.");
uint rows = 3;
uint columns = 3;
uint z = 3;

if (rows * columns * z < 100)
{
    int[,,] matrix = MatrixInit3D(rows, columns, z);
    Console.WriteLine($"\nВот сгенерированная матрица {rows}x{columns}x{z}:");
    PrintMatrix3D(matrix);
}
else
{
    Console.WriteLine("Слишком большая матрица, числа будут повторяться");
}


