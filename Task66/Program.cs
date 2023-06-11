// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

bool CheckNumbers(int numM, int numN)
{
    return numN < 0 || numM < 0;
}

int SumElements(int numM, int numN)
{
    if (numM > numN)
    {
        return numM + SumElements(numM - 1, numN);
    }
    else if (numM < numN)
    {
        return numM + SumElements(numM + 1, numN);
    }
    else
    {
        return numM;
    }
}

Console.WriteLine("Please enter your first number: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second number: ");
int numberN = Convert.ToInt32(Console.ReadLine());


if (CheckNumbers(numberM, numberN))
{
    Console.WriteLine("Error!");
}
else
{ 
    int sumElements = SumElements(numberM, numberN);
    Console.WriteLine($"Sum of all elements from {numberM} to {numberN} is {sumElements}");
}
