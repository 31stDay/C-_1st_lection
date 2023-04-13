// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>= 100)
FindThirdDigit(number);
else
Console.WriteLine("Your number contains less than three digits");

int FindThirdDigit(int num)
{
    

}