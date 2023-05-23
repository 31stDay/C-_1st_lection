// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// test

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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

bool CheckMatrices(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix[i, j] = matrix[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix;
}



int[,] matr1 = CreateMatrix(rows: 4, columns: 2, min: 1, max: 10);
PrintMatrix(matr1);
Console.WriteLine();

int[,] matr2 = CreateMatrix(rows: 2, columns: 3, min: 1, max: 10);
Console.WriteLine();
PrintMatrix(matr2);
Console.WriteLine();

if (CheckMatrices(matr1, matr2))
{
    int[,] matr = MatrixMultiplication(matr1, matr2);

    Console.WriteLine("The resulting matrix:");
    Console.WriteLine();
    PrintMatrix(matr);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Matrix P can be multiplied by matrix K only if\n the number of columns of matrix P is equal\n to the number of rows of matrix K");
}
