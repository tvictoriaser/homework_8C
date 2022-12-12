// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Console.WriteLine("Матрица A");
int[,] arrayNumberOne = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(arrayNumberOne);
Console.WriteLine("Матрица B");
int[,] arrayNumberTwo = CreateMatrixRndInt(4, 5, 0, 3);
PrintMatrix(arrayNumberTwo);
if (arrayNumberOne.GetLength(1) == arrayNumberTwo.GetLength(0))
{
    Console.WriteLine("Перемножение матриц:");
    int[,] matrixMultiplication = MatrixMultiplication(arrayNumberOne, arrayNumberTwo);
    PrintMatrix(matrixMultiplication);
}
else Console.WriteLine("Матрицу A можно умножить на матрицу B только в том случае, если число столбцов матрицы A равняется числу строк матрицы B");
