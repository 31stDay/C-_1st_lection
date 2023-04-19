// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int RaisingToAPower(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine("Please enter the first positive integer number: ");
int aNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the second positive integer number: ");
int bNumber = Convert.ToInt32(Console.ReadLine());

int raisingToAPower = RaisingToAPower(aNumber, bNumber);
Console.WriteLine($"{aNumber} raised to the power of {bNumber} is {raisingToAPower}");
