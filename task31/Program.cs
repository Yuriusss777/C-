﻿int[] CreatArrayRndInt(int size, int min, int max) // создать массив со случайными числами с параметрами: размер массива, мин значение и макс. значение для диапозона
{
    int[] arr = new int[size]; // создаем массив с размером size
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) //arr.Length - количество элементов созданного массива, можно и size использовать
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr; // возвращаем готовый массив
}

void PrintArray(int[] arr) // метод, который выводит в консоль результаты  
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[1]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] array = CreatArrayRndInt(12, -9, 9); // создаем метод с параметрами
PrintArray(array);
Console.Write(" -> [");
PrintArray(array);
Console.Write("]");
