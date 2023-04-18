// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


long SumNumbers(long num)
{
    long sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum + i;
        }
    }
    return sum;
}

Console.WriteLine("Please enter your positive integer number: ");
long number = Convert.ToInt64(Console.ReadLine());

long sumNumber = SumNumbers(number);
Console.WriteLine($"Sum  of numbers from 1 to {number} = {sumNumber}");