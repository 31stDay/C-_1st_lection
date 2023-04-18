// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int DigitCount (int num)
{
   int count = 0;
   for (int i = 0; i <= num; i++)
   {
     num = num / 10;
     count += 1;
   }
   return count;
}

Console.WriteLine("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int digitCount = DigitCount(number);
Console.WriteLine($"Please note that your number contains {digitCount} digits");