// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int num)
{
    int sum = 0;
    int tNum = num;
    while (tNum > 0)
    {
        int reminder = num % 10;
        sum = sum + reminder;
        tNum = tNum / 10;
    }
    return sum;
}

Console.WriteLine("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfDigits = SumOfDigits(number);
Console.WriteLine($"Please be informed that the sum of all digits in your number is {sumOfDigits}");