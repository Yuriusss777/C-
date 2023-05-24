Console.WriteLine("Введите длину массива");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] arr = Array(lengthArray);
PrintArray(arr);

int[] Array(int size)
{
    int[] array = new int[size]; // массив array состоящий и size элементов типа инт
    Random random = new Random(); // опритмизация объектов random
    for (int i = 0; i < size; i++) // определили элемент массива для каждого индекса
    {
        array[i] = random.Next (0, 10); // сгенерировали рандомное число
    }
    return array; // вывели 
   }
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

