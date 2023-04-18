// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ProductOfNumbers(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            prod *= i;
        }
    }
    return prod;
}

Console.WriteLine("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int prodOfNumbers = ProductOfNumbers(number);
Console.WriteLine($"Sum  of numbers from 1 to {number} = {prodOfNumbers}");