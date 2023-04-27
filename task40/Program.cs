Console.WriteLine("Введите сторону А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону С: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int numA, int numB, int numC)
{
    // if (numA < numB + numC && numB < numA + numC && numC < numA + numB)
    return numA < numB + numC && numB < numA + numC && numC < numA + numB;
    //     return true;
    // else return false;
}

bool existTriangle = IsExistTriangle(numberA, numberB, numberC);
Console.WriteLine(existTriangle ? "Такой треугольник существует" : "Такого треугольника нет");

