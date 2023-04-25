// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

// (a + b) > c && (b + c) > a && (c + a) > b;

bool CheckTriangle(int a, int b, int c)
{
    return (a + b) > c && (b + c) > a && (c + a) > b;   
}

bool checkTriangle = CheckTriangle(number1, number2, number3);
Console.WriteLine();
Console.WriteLine(checkTriangle ? "Triangle with given sides exists" : "triangle with given sides doesn't exist");