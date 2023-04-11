// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);  // last number isn't included
Console.WriteLine($"Random number from range 10 - 99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
 Console.WriteLine($"Please note that the first digit {firstDigit} in the number {number} is greater then the second one {secondDigit}");   
else
 Console.WriteLine($"Please note that the second digit {secondDigit} in the number {number} is greater then the second one {firstDigit}");  
