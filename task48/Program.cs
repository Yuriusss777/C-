int[,] CreatMatrixRndInt(int rows, int columns, int min, int max) // двумерный массив обозначается одной запятой, 
// rows - обазначили размер массива х, columns - обазначили размер массива y
{
    int[,] matrix = new int[rows, columns]; // создаем массив с размером size
        for (int i = 0; i < matrix.GetLength(0); i++) //GetLength(0) - измерение количества строк, 0 - это нулевой индекс массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }

    }
    return matrix; // возвращаем готовый массив
}

void Printmatrix(int[,] matrix) // метод, который выводит в консоль результаты  
{
    for (int i = 0; i < matrix.GetLength(0); i++) //GetLength(0) - измерение количества строк, 0 - это нулевой индекс массива
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} "); // 5 - отступ
        }
        Console.WriteLine(" |");
    }
}

int[,] array2d = CreatMatrixRndInt(3, 4, -100, 100);
Printmatrix(array2d);