// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите индекс двумерного массива в строке");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс двумерного массива в столбце");
int number2 = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreatMatrixRndInt(3, 4, 0, 10);
Printmatrix(array2d);
bool matrixElements = MatrixElements(array2d, number1, number2);
Console.WriteLine();
Console.Write(matrixElements ? array2d[number1, number2] : "Такого элемента в массиве нет");


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

bool MatrixElements(int[,] matrix, int number1, int number2)
{
    if (number1 < matrix.GetLength(0) && number2 < matrix.GetLength(1))
        return true;
    else
        return false;
}

