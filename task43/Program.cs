// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
int number4 = Convert.ToInt32(Console.ReadLine());

double x = X(number1, number2, number3, number4);
double y = Y(number1, number2, number3, number4, x);
Console.WriteLine($"{x}; {y}");

double X(double num1, double num2, double num3, double num4)
{
    double x = -(num1 - num2) / (num3 - num4);
    return x;
}

double Y(double num1, double num2, double num3, double num4, double x)
{
    double y = num4 * x + num2;
    return y;
}