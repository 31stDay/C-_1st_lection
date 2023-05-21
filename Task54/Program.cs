// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateMatrix(int rows, int columns, int min, int max)
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
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

void SortMatrixRows(int[,] matrix)
{
    int rowInd = 0;

    for (rowInd = 0; rowInd < matrix.GetLength(0); rowInd++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[rowInd, col] < matrix[rowInd, col + 1])
                {
                    int temp = matrix[rowInd, col];
                    matrix[rowInd, col]= matrix[rowInd, col + 1];
                    matrix[rowInd, col + 1] = temp;
                }
            }
        }
    }
}

int[,] matr = CreateMatrix(rows: 4, columns: 4, min: 1, max: 10);
PrintMatrix(matr);
Console.WriteLine();
SortMatrixRows(matr);
PrintMatrix(matr);
