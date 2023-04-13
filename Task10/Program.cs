// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ShowMidDigit(int thNum)
{
    int mNumber = (thNum % 100) / 10;
    return mNumber;
}

Console.WriteLine("Please enter a three-digit number: ");
int thNumber = Convert.ToInt32(Console.ReadLine());

if (thNumber >= 100 && thNumber <= 999)
{
    int midNumber = ShowMidDigit(thNumber);
    Console.WriteLine($"Please note that the middle digit of your number is- {midNumber}");
}
else
{
    Console.WriteLine("Your number isn't three digits.");
}
