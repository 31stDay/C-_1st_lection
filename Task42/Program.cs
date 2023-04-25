// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Enter a positive natural decimal number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Convert10to2(int num)
{
    int result = 0;
    int i = 1;
    while (num > 0)
    {
        result += (num % 2) * i;
        num /= 2;
        i *= 10;
    }
    return result;
}
int convert10to2 = Convert10to2(number);
Console.WriteLine(convert10to2);