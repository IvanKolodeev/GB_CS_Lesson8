// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArrayRandom(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }

    return result;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    if (columns1 != rows2)
    {
        Console.WriteLine("Matrices cannot be multiplied, columns of matrix1 must equal rows of matrix2");
        return;
    }

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }

    Print2DArray(result);
}

int rows = 2;
int columns = 2;

int[,] matrix1 = CreateArrayRandom(rows, columns, 0, 10);
Console.WriteLine("Your Matrix 1 is");
Print2DArray(matrix1);
int[,] matrix2 = CreateArrayRandom(rows, columns, 0, 10);
Console.WriteLine("Your Matrix 2 is");
Print2DArray(matrix2);
Console.WriteLine("Your Matrix multiplication is");
MultiplyMatrices(matrix1, matrix2);