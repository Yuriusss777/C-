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
int[] array = CreatArrayRndInt(123, 0, 1000);
int sectionElements = SectionElements(array);
int SectionElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        {
        if(array[1] >= 10 && array[i] <= 99) sum += 1; 
    }
    return sum;
}






Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"-> {sectionElements}");  


