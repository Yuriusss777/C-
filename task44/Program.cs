Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacci = Fibonacci(number);
PrintArray(fibonacci);


int[] Fibonacci(int size)
{
    int[] arr = new int[size];
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}