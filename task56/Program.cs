// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

int[] GetSumRow(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[k] = sum;
        k++;
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int FindSmallSum(int[] arr)
{
    int smallSum = arr[0];
    int smallRow = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (smallSum > arr[i])
        {
            smallSum = arr[i];
            smallRow = i + 1;
        }
    }
    return smallRow;
}


int[,] array2D = CreateMatrixRndInt(5, 6, -10, 10);
PrintMatrix(array2D);

int[] array1D = GetSumRow(array2D);
Console.WriteLine("Сумма элементов массива по строкам:");
PrintArray(array1D);
Console.WriteLine();
Console.Write("Строка с наименьшей суммой элементов -> ");
int findSmallSum = FindSmallSum(array1D);
Console.WriteLine($"{findSmallSum}");



