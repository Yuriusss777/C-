﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}

void StrMinSumElements(int[,] matrix)
{
    int minSumRow = 0;
    int strMinSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minSumRow += matrix[0, i];
    }
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        sumRow += matrix[i, j];
        
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            strMinSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"номер строки с наименьшей суммой элементов -> {strMinSumRow + 1} строка");
}

int[,] matrix = CreatMatrixRndInt(5, 4, -10, 10);
Printmatrix(matrix);
Console.WriteLine();
StrMinSumElements(matrix);
