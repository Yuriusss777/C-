// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите неотрицательное число");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число");
int numberM = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(numberM, numberN);


void AkkermanFunction(int numN, int numM)
{
    Console.Write(Akkerman(numN, numM));
}

int Akkerman(int numN, int numM)
{
    if (numN == 0)
    {
        return numM + 1;
    }
    else if (numM == 0)
    {
        return Akkerman(numN - 1, 1);
    }
    else
    {
        return (Akkerman(numN - 1, Akkerman(numN, numM - 1)));
    }
}