// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreatArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}



double MinNumber(double[] arr)
{
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    double min1 = Math.Round(min, 1);
    return min1;
}


double MaxNumber(double[] arr)
{
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    double max1 = Math.Round(max, 1);
    return max1;
}

double[] array = CreatArrayRndDouble(7, 1, 1000);
double minNumber = MinNumber(array);
double maxNumber = MaxNumber(array);

Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементов массива = {maxNumber - minNumber}");
