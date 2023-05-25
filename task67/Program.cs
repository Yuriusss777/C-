// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine(sumDigits);


int SumDigits(int num)
{
    if (num == 0) return 0;
    return num%10 + SumDigits(num / 10);
}


