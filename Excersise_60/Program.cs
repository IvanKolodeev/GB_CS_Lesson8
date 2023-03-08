// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DArrayRandom(int rows, int columns, int thirdDimension, int min, int max)
{
    int[,,] result = new int[rows, columns, thirdDimension];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < thirdDimension; k++)
            result[i, j, k] = new Random().Next(min, max);
        }
    }

    return result;
}

void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] matrix = Create3DArrayRandom(2, 2, 2, 10, 99);
Console.WriteLine("Your Matrix is");
Print3DArray(matrix);