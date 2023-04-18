Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int quantity = Quantity(number);
Console.WriteLine($"количество цифр в числе = {quantity}");

int Quantity(int num) // int num = number
{
    int count = 0;
    for (int i = 1; num > 0; i++)
    {
        num /= 10;
        count = i;
    }
    return count;
}
