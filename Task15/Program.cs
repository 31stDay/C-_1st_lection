// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool CheckDayOfWeek(int number)
{
    return number == 6 || number == 7;
}

Console.WriteLine("Please enter a number from 1 to 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber >= 1 && dayNumber <= 7)
{
    bool result = CheckDayOfWeek(dayNumber);
    Console.WriteLine(result ? "Yes" : "No");
}
else
{
    Console.WriteLine($"Your number- {dayNumber} is out of range 1-7");
}
