// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Promt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


bool CheckNumberLength(int num)
{
    if (num >= 10000 && num < 100000)
    {
        return true;
    }
    Console.WriteLine("Your number contains more or less then 5 digits.");
    return false;
}

bool CheckPalindrome(int numb)
{
    int length = numb.ToString().Length;
    int[] array = new int[length];
    int tempNumber = numb;
    int revNumb = 0;
    for (int i = 0; i < length; i++)
    {
        int reminder = tempNumber % 10;
        array[i] = reminder;
        tempNumber = tempNumber / 10;
        revNumb += array[i] * Convert.ToInt32(Math.Pow(10, length - i - 1));
    }
    if (revNumb == numb)
    {
        Console.WriteLine("Your number is a palindrome");
        return true;
    }
    Console.WriteLine("Your number isn't a palendrome");
    return false;
}

int number = Promt("Please enter five-digit number: ");
if (CheckNumberLength(number))
{
    Console.WriteLine(CheckPalindrome(number));
}