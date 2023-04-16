// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки А");
Console.Write("x1: ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int zACoordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
Console.Write("x2: ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int zBCoordinate = Convert.ToInt32(Console.ReadLine());

double distans = Distans(xACoordinate, yACoordinate, zACoordinate, xBCoordinate, yBCoordinate, zBCoordinate);
double distansRound = Math.Round(distans, 2, MidpointRounding.ToZero);
Console.WriteLine(distansRound);

double Distans(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distans = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return distans;
}