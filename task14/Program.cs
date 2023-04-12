int number = new Random().Next(0, 1000);
Console.WriteLine($"введите число -> {number}");



int result = Result(number);
if(result == 0)
Console.WriteLine("-> да");
else
Console.WriteLine("-> нет");

int Result(int num)
{
    int result = number %(7 * 23);
    return result;
}
