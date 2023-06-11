// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

bool CheckNumbers(int numN, int numM)
{
    return numN < 0 || numM < 0;
}

int AckermannFunction(int numN, int numM)
{
    if(numN == 0) return numM + 1;
    else if (numM == 0) return AckermannFunction(numN - 1, 1);
    else return AckermannFunction(numN - 1, AckermannFunction (numN, numM - 1));
}

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

Console.WriteLine("Please enter your first number: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second number: ");
int numberM = Convert.ToInt32(Console.ReadLine());


if (CheckNumbers(numberN, numberM))
{
    Console.WriteLine("Error!");
}
else
{ 
    int ackermannFunction = AckermannFunction(numberN, numberM);
    Console.WriteLine($"The result is {ackermannFunction}");
}
