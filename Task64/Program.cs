// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

bool CheckNumbers(int num)
{
    return num < 0;
}

void DisplayNumbers(int num)
{
    if(num == 0) return;
    Console.Write($"{num}");
    DisplayNumbers(num - 1);
}

Console.WriteLine("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckNumbers(number))
{
    Console.WriteLine("Error!");
}
else
{ 
    DisplayNumbers(number);
}