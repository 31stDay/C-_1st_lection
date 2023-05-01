// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int CountNumbersGTzero(int amountOfNumbers)
{
int counter = 0;
for (int i = 0; i < amountOfNumbers; i++)
{
    Console.WriteLine($"Please enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        counter++;
    }
}
return counter;
}

Console.WriteLine($"Please specify how many numbers are you going to enter: ");
int sumOfNumbers = Convert.ToInt32(Console.ReadLine());

int count = CountNumbersGTzero(sumOfNumbers);
Console.WriteLine($"Please note that you've entered {count} numbers greater than zero");