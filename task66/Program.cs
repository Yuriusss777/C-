// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());


if (numberM >= 0 && numberN >= 0)
{
    int sumNaturalNumbers = SumNaturalNumbers(numberM, numberN);
    Console.WriteLine(sumNaturalNumbers);
}
else Console.Write("Введено не натуральное число");

int SumNaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        return numM + SumNaturalNumbers(numM + 1, numN);
    }

    else if (numM > numN)
    {
        return numN + SumNaturalNumbers(numN + 1, numM);
    }
    return numM;
}