Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int prNumbers = PrNumbers(number);
Console.WriteLine($"произедение чисел от 1 до {number} = {prNumbers}");


int PrNumbers(int num) // int num = number
{
    int pr = 1;
    for (int i = 1; i <= num; i++)
    {
        pr = pr * i; //sum += i
    }
    return pr;
    }