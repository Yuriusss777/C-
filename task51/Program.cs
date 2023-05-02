int[,] CreatMatrixRndInt(int rows, int columns, int min, int max) // двумерный массив обозначается одной запятой, 
// rows - обазначили размер массива х, columns - обазначили размер массива y
{
    int[,] matrix = new int[rows, columns]; // создаем массив с размером size
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //GetLength(0) - измерение количества строк, 0 - это нулевой индекс массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

int DiagonalSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                sum += matrix[i, j];
        }
    }
    return (sum);
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

int[,] array2d = CreatMatrixRndInt(3, 4, 0, 10);
int diagonalSum = DiagonalSum(array2d);
Printmatrix(array2d);
Console.WriteLine();
Console.Write($"Сумма индексов основоной диагонали = {diagonalSum}");