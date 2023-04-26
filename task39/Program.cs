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

//array.Revers(array);

void ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
int temp = arr[i]; //присвоение временного элемента
arr[i] = arr[arr.Length - 1 -i];
arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = CreatArrayRndInt(5, 1, 9);
PrintArray(array);
Console.WriteLine();
ReversArray(array);
PrintArray(array);