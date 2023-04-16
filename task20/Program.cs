// double d = Math.Sqrt(5);

// double d1 = 5.09987654;
// double d1Round = Math.Round(d1, 2, MidpointRounding.ToZero);
// Console.WriteLine(d1Round);


// Console.WriteLine("Введите координаты точки А");
// Console.Write("x1: ");
// int xCoordinateA1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y1: ");
// int yCoordinateA1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки В");
// Console.Write("x2: ");
// int xCoordinateA2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y2: ");
// int yCoordinateA2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки А");
Console.Write("x1: ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
Console.Write("x2: ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());


double distans = Distans(xACoordinate, yACoordinate, xBCoordinate, yBCoordinate);
double distansRound = Math.Round(distans, 2, MidpointRounding.ToZero);
Console.WriteLine(distansRound);

double Distans(int x1, int y1, int x2, int y2)
{
//    int deltaX = x1 - x2;
//    int deltaY = y1 - y2; 
   double distans = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
// double distans = deltaX * deltaX + deltaY * deltaY;
   return distans;
}



