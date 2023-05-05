// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CheckLines(int b1, int k1, int b2, int k2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2 && b1 == b2)
    {
        Console.Write("Lines coincide");
    }
    else if (k1 == k2)
    {
        Console.Write("Lines are parallel");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine($" Coordinates of the point of intersection of two lines are x= {Math.Round(x, 2)} y= {Math.Round(y, 2)}");
    }
}

Console.WriteLine($"Please enter b1: ");
int varB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Please enter k1: ");
int varK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Please enter b2: ");
int varB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Please enter k2: ");
int varK2 = Convert.ToInt32(Console.ReadLine());


CheckLines(varB1, varK1, varB2, varK2);

