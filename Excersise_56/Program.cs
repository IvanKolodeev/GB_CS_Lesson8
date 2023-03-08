// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int rows = 4;
int columns = 4;

int[,] matrix = CreateArrayRandom(rows, columns, -10, 10);
Print2DArray(matrix);

int temp = 0;
int minRow = 0;

for (int i = 0; i < rows; i++)
{
    int sum = 0;

    for (int j = 0; j < columns; j++)
    {
        sum += matrix[i, j];
    }

    Console.WriteLine($"Sum of elements in {i} row is {sum}");
    if (i == 0) temp = sum;
    else if (sum < temp) 
    {
        temp = sum;
        minRow = i;
    }
}

Console.WriteLine($"Row with minimun sum of values is {minRow}");