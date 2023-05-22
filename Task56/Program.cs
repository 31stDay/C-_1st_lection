// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка



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

void FindSmallestRow(int[,] matrix)
{
    int rowNumber = 0;
    int sum = 0;
    double average = 0;
    int i = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
    }
    average = sum / matrix.GetLength(1);
    double minAverage = average;

    for (i = 1; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        average = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        average = sum / matrix.GetLength(1);
        if (average < minAverage)
        {
            minAverage = average;
            rowNumber = i;
        }
    }
    Console.WriteLine($"Please note that the row number {rowNumber + 1} has a smallest average value: {minAverage}");
}


int[,] matr = CreateMatrix(rows: 4, columns: 4, min: 1, max: 10);
PrintMatrix(matr);
Console.WriteLine();
FindSmallestRow(matr);
Console.WriteLine();