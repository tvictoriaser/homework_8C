// Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] CreateMatrixSpiral(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int element = 1;
    int i = 0;
    int j = 0;
    while (element <= rows * columns)
    {
        matrix[i, j] = element;
        if (i <= j + 1 && i + j < columns - 1)
            ++j;
        else if (i < j && i + j >= rows - 1)
            ++i;
        else if (i >= j && i + j > columns - 1)
            --j;
        else
            --i;
        ++element;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($" {matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix2D = CreateMatrixSpiral(4, 4);
PrintMatrix(matrix2D);