// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Please enter five-digit number: ");
Convert.ToInt32(Console.ReadLine());

int Promt()
{
    ;
}


bool CheckTheNumber(int num)
{
    if (num >= 10000 && num < 100000)
    {
        return true;
    }
    Console.WriteLine("Your number contains more or less then 5 digits.");
    return false;
}