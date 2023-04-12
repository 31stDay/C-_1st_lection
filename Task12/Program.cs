// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
int Rest(int num1, int num2)
{

}

Console.WriteLine("Please enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int rest = Rest(number1, number2);
Console.WriteLine($"{rest}");
