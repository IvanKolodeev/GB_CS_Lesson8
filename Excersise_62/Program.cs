// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string formatedNumber = matrix[i, j].ToString("00");
            Console.Write($"{formatedNumber}\t");
        }
        Console.WriteLine();
    }
}

int n = 4; // size of the 2D array
int[,] arr = new int[n, n];
int num = 1; // starting number

int rowStart = 0;
int rowEnd = n - 1;
int colStart = 0;
int colEnd = n - 1;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    // Fill in the top row
    for (int i = colStart; i <= colEnd; i++)
    {
        arr[rowStart, i] = num++;
    }
    rowStart++;

    // Fill in the right column
    for (int i = rowStart; i <= rowEnd; i++)
    {
        arr[i, colEnd] = num++;
    }
    colEnd--;

    // Fill in the bottom row
    for (int i = colEnd; i >= colStart; i--)
    {
        arr[rowEnd, i] = num++;
    }
    rowEnd--;

    // Fill in the left column
    for (int i = rowEnd; i >= rowStart; i--)
    {
        arr[i, colStart] = num++;
    }
    colStart++;
}


Print2DArray(arr);