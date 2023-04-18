Console.WriteLine("Введите длину массива");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] arr = Array(lengthArray);
PrintArray(arr);

int[] Array(int size)
{
    int[] array = new int[size];
    Random random = new Random(); // опритмизация объектов random
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next (0, 1000);
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

