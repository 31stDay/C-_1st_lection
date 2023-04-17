// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return dist;
}

Console.WriteLine("Please enter the first point coordinates");
Console.WriteLine("Please enter X: ");
int xaCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter Y: ");
int yaCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter Z: ");
int zaCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second point coordinates");
Console.WriteLine("Please enter X: ");
int xbCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter Y: ");
int ybCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter Z: ");
int zbCoord = Convert.ToInt32(Console.ReadLine());


double distance = Distance(xaCoord, yaCoord, zaCoord, xbCoord, ybCoord, zbCoord);
double distanceRound = Math.Round(distance, 2);
Console.WriteLine($"The distance between the points is {distanceRound}");