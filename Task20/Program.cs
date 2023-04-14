// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// double d = Math.Round(Math.Sqrt(5), 2);
// // double d = Math.Sqrt(5);

// // double d1 = 5.09987654;
// // double d1Round = Math.Round(d1, 2, MidpointRounding.ToZero);
// // Console.WriteLine(d1Round);

// System.Console.WriteLine(d);

Console.WriteLine("Please enter the first point coordinates");
Console.WriteLine("Please enter X: ");
int xaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter Y: ");
int yaCoordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second point coordinates");
Console.WriteLine("Please enter X: ");
int xbCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter Y: ");
int ybCoordinate = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return dist;
}

double distance = Distance(xaCoordinate, yaCoordinate, xbCoordinate, ybCoordinate);
double distanceRound = Math.Round(distance, 2);
Console.WriteLine(distanceRound);
