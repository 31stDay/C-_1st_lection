// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

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

// int convert10to2int = Convert10to2Int(number);
// Console.WriteLine(convert10to2int);
// for (int i = 0; i < convert10to2String.Length; i++)
// {
//    Console.Write(convert10to2String[convert10to2String.Length - 1 - i]);
// }


Console.Write("Enter a positive natural decimal number: ");
int number = Convert.ToInt32(Console.ReadLine());

int convert10to2 = Convert10to2(number);
Console.WriteLine(convert10to2);