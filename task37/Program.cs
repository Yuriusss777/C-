int[] CreatArrayRndInt(int size, int min, int max) // создать массив со случайными числами с параметрами: размер массива, мин значение и макс. значение для диапозона
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
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] array = CreatArrayRndInt(7, 0, 10);
int[] pairsNumbers = PairsNumbers(array);
int[] PairsNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length %2 == 1) size += 1;

    int[] newArr = new int[size];
    for (int i = 0; i < arr.Length/2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length %2 == 1) newArr[newArr.Length-1] = arr[arr.Length / 2];
  return newArr;  
}



Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
Console.Write("-> [");
PrintArray(pairsNumbers);
Console.Write("]");




