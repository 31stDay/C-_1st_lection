// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    int rnd = 0;

        int i=0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd + 1;
        }
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = rnd + 1;
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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}


int[,] matr1 = CreateMatrix(rows: 4, columns: 2, min: 1, max: 10);
PrintMatrix(matr1);