// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

void CheckElement(int[,] matrix, int elRow, int elCol)
{

    if (elRow > matrix.GetLength(0) - 1 || elCol > matrix.GetLength(1) - 1 || elRow < 0 || elCol < 0)
    {
        Console.WriteLine("There is no such element in the matrix");
    }
    else Console.WriteLine($"Your element is: {matrix[elRow, elCol]}");
}

Console.WriteLine("Please enter element position in row: ");
int elementRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter element position in column: ");
int elementColumn = Convert.ToInt32(Console.ReadLine());

int[,] matr = CreateMatrix(3, 4, 1, 10);
PrintMatrix(matr);
CheckElement(matr, elementRow, elementColumn);

