// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] CreatMatrixRndInt2(int rows2, int columns2, int min, int max)
{
    int[,] matrix2 = new int[rows2, columns2];
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;
}

void Printmatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}

int[,] NewMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix3.GetLength(1); i++)
    {
        for (int j = 0; j < matrix3.GetLength(0); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < matrix.GetLength(1); n++)
            {
                matrix3[i, j] += matrix[i, n] * matrix2[n, j];
            }
        }
    }
    return matrix3;
}

void Printmatrix3(int[,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            Console.Write($"{matrix3[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}


int[,] matrix = CreatMatrixRndInt(3, 2, -10, 10);
Printmatrix(matrix);
Console.WriteLine();
int[,] matrix2 = CreatMatrixRndInt2(2, 3, -10, 10);
Printmatrix2(matrix2);
Console.WriteLine();
if (matrix.GetLength(0) == matrix2.GetLength(1))
{
    int[,] matrix3 = NewMatrix(matrix, matrix2);
    Printmatrix3(matrix3);
}
else
    Console.WriteLine("Количество строк первой матрицы не совпадает с количеством столбцов второй матрицы");

