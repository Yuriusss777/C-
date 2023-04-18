Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number1, number2);
Console.WriteLine(sum);


int Sum(int num1, int num2)
{
    int sum1 = num1;
    for (int i = 2; i <= num2; i++)
    {
        sum1 = sum1 * num1;
    }
    return sum1;
    }
