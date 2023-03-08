// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Print2DArray(int[,] matrix)
{
    Console.WriteLine("Your matrix is");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayRandom(int rows, int columns, int min, int max)
{
    int [,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }

    return result;
}

void SortArrayRows (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxIndex = j;
            for (int k = j+1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,k] > matrix[i,maxIndex])  maxIndex = k;
            }

        int temp = matrix[i,j];
        matrix[i,j] = matrix[i,maxIndex];
        matrix[i, maxIndex] = temp;
        }   
    }
}


int[,] matrix = CreateArrayRandom(3, 4, 0, 10);
Print2DArray(matrix);
SortArrayRows(matrix);
Print2DArray(matrix);

