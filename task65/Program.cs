// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


Console.WriteLine("Введите целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(numberM, numberN);

void NaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbers(numM + 1, numN);
    }
    else if (numM > numN)
    {
        Console.Write($"{numN} ");
        NaturalNumbers(numN + 1, numM);
    }
    else Console.Write(numM);
}