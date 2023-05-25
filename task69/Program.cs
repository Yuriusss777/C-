// Напишите программу, которая будет принимать на вход два числа А и В, и возводит число А в целую степень В с помощью рекурсии.


Console.WriteLine("Введите целое положительное число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree = Degree(numberA, numberB);
Console.WriteLine(degree);


int Degree(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * Degree(numA, numB - 1);
}

