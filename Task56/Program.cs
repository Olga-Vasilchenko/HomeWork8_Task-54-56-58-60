// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int MinSumElements(int[,] matrix)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i]; 
    }
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
        minRow = sumRow;    
        minSumRow = i;
        }
    sumRow = 0;
    }
return minSumRow;
}

int[,] array2D = RandomMatrix(4, 4, 1, 9);
PrintMatrix(array2D, "|", "", "|");
Console.WriteLine();
Console.WriteLine($"{MinSumElements(array2D) + 1} строка");