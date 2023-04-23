// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] array = CreatArrayRndInt(7, 100, 1000);
int sumEvenElements = SumEvenElements(array);
int SumEvenElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        {
        if (arr[i] %2 == 0) sum += 1;
    }
    return sum;
}

Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
Console.Write($"Количество четных чисел в массиве -> {sumEvenElements}");
