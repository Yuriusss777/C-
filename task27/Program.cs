Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());



int sum = Sum(number);
Console.WriteLine(sum);

int Sum(int num) // int num = number
{
    int sum1 = 0;
    for (int i = 0; num > 0; i++)
    {
        sum1 = sum1 + num % 10;
        num = num / 10;
    }
    return sum1;
}
