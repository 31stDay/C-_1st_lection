﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int FindThirdDigit(int num)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int thDig = num % 10;
    return thDig;
}

Console.WriteLine("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
   int thirdDigit = FindThirdDigit(number);
   Console.WriteLine($"The third digit of your number{number} is {thirdDigit}");
} 
else
    Console.WriteLine("Your number contains less than three digits.");

