// Задача 4: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Please enter your first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;
if (numberB > numberA)
{
    max = numberB;
    if (numberC > numberB)
    {
        max = numberC;
        Console.WriteLine($"The third number is the maximum- {numberC}");
    }
    Console.WriteLine($"The second number is the maximum- {numberB}");
}
else if (numberC > numberA)
{
    Console.WriteLine($"The third number is the maximum- {numberC}");
}
else
{
    Console.WriteLine($"The first number is the maximum- {numberA}");
}
