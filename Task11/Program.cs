// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);  // last number isn't included
Console.WriteLine($"Random number from range 100 - 999 -> {number}");

int DeleteMid(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int newNumber = (firstDigit * 10) + lastDigit;
    return newNumber;
}
int midNumber = DeleteMid(number);

Console.WriteLine($"two-digit number is {midNumber}");
