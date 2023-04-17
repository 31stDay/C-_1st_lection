// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string Quarter(int n)
{
    if (n == 1) return "x > 0 && y > 0";
    if (n == 2) return "x < 0 && y > 0";
    if (n == 3) return "x < 0 && y < 0";
    if (n == 4) return "x > 0 && y < 0";
    return null;
}

Console.WriteLine("Please enter coordinate quarter number from 1 to 4: ");
int coordinateQuarter = Convert.ToInt32(Console.ReadLine());

string range = Quarter(coordinateQuarter);
Console.WriteLine(range == null
                    ? "Coordinates quarter number is wrong"
                    : $"The range of possible coordinates of points in the quarter you specified is {range}");



