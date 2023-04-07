
Console.WriteLine("Please enter a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a second number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 * number2 == number1)
{
    Console.WriteLine("Number one is a square of number two");
}
else
{
    Console.WriteLine("Number one isn't a square of number two");
}