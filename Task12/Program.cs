// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
int Reminder(int num1, int num2)
{
    return num1 % num2;
}

Console.WriteLine("Please enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int rem = Reminder(number1, number2);
if (rem == 0)
    Console.WriteLine("The fist number is multiple of the second");
else
    Console.WriteLine($"The reminder of the division is {rem}");
