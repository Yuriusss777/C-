// задать двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива


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

void SwapPosition(int[,] matrix)
{
    int lastPosition = matrix.GetLength(0) - 1;
    int firstPosition = 0;
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[firstPosition, j];
        matrix[firstPosition, j] = matrix[lastPosition, j];
        matrix[lastPosition, j] = temp;
    }
}


int[,] matrix = CreatMatrixRndInt(4, 4, -10, 10);
Printmatrix(matrix);
Console.WriteLine();
SwapPosition(matrix);
Printmatrix(matrix);
