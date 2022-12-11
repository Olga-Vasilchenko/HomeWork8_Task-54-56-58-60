// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] RandomMatrix(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}"); 
            else Console.Write($"{matrix[i, j], 4} ");
        }                                    
        Console.WriteLine(endRow);
    }
}

int[,] MultiplikationTwoMatrix(int[,] firstmatrix, int[,] secondmatrix, int rows, int columns)
{
    int[,] multMatrix = new int[rows, columns];
    if (firstmatrix.GetLength(0) == secondmatrix.GetLength(0) && firstmatrix.GetLength(1) == secondmatrix.GetLength(1))
        for (int i = 0; i < firstmatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondmatrix.GetLength(1); j++)
            {
                for (int k = 0; k < firstmatrix.GetLength(1); k++)
                {
                    multMatrix[i, j] = firstmatrix[i, k] * secondmatrix[k, j];
                }
            }
        }
        else
        Console.WriteLine($"Перемножение невозможно, матрицы по размеру не одинаковы");
        return multMatrix;
}

int[,] array2D = RandomMatrix(2, 2, 1, 9);
int[,] secondArray2D = RandomMatrix(2, 2, 1, 9);
PrintMatrix(array2D, "|", "", " |");
Console.WriteLine();
PrintMatrix(secondArray2D, "|", "", " |");
Console.WriteLine();
int[,] multMatrix = MultiplikationTwoMatrix(array2D, secondArray2D, 2, 2);
PrintMatrix(multMatrix, "|", "", " |");
