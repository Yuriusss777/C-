// int[] array = new int[8]; //{8, 8, 9, 3, 2, 4, 2, 1}
// int[] arr = {8, 8, 9, 3, 2, 4, 2, 1};
// array[0] = 34; 
// int size = array.Length; // свойство, показывающее количество элементов в массиве


Console.WriteLine("Введите длину массива");
int lengthArray = Convert.ToInt32(Console.ReadLine());
// int size = array.Length;

int[] arr = Array(lengthArray);
PrintArray(arr);

int[] Array(int size)
{
    int[] array = new int[lengthArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
    // Console.WriteLine($"{array[1], 3}");
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
