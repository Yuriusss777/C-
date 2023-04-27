// напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int resultBin = DecTobin(number);
    Console.WriteLine(resultBin);
}
else Console.WriteLine("ввели неверное число");


int DecTobin(int num)
{
    int result = 0;
    int count = 1;
    while (num > 0)
    {
        result += num % 2 * count;
        count = count * 10;
        // count = num % 2;
        // result = result * 10 + count;
        num /= 2;
    }
    return result;
}

