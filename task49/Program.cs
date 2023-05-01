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

void EvenElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }

    }
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

int[,] array2d = CreatMatrixRndInt(3, 4, -10, 10);
Printmatrix(array2d);
Console.WriteLine();
EvenElements(array2d);
Printmatrix(array2d);

