// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    Console.WriteLine($"Please be informed that your number {number} is even.");
else
    Console.WriteLine($"Please be informed that your number {number} is odd.");