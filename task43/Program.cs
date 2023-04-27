// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите необходимое количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int[] newArr = Array(number);
    int positivNumber = PositivNumber(newArr);
    Console.WriteLine($"введенных чисел больше 0 = {positivNumber}");
    PrintArray(newArr);
}
else Console.WriteLine("ввели неверное число");


int[] Array(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите элемент c индексом {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());

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

int PositivNumber(int[] newArr)
{
    int count = 0;
    for (int i = 0; i < newArr.Length; i++)
    {
        if (newArr[i] > 0) count += 1;
    }
    return count;
}