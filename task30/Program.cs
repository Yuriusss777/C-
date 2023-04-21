// int[] array = new int[8]; //{8, 8, 9, 3, 2, 4, 2, 1}
// int[] arr = {8, 8, 9, 3, 2, 4, 2, 1};
// array[0] = 34; 
// int size = array.Length; // свойство, показывающее количество элементов в массиве


Console.WriteLine("Введите длину массива");
int lengthArray = Convert.ToInt32(Console.ReadLine());
// int size = array.Length;

int[] arr = Array(lengthArray);


int[] Array(int size)
{
    int[] array = new int[size];
    Random random = new Random(); // опритмизация объектов random
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next (0, 2);
    }
    return array;
   }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write($"[");
PrintArray(arr);
Console.Write($"]");