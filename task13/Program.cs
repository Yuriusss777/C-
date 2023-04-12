Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Result(number);
// int result = number;
// while (result >= 999)
// {
//     result = result / 10;
// }

// if (number < 0)
// number = -number; 
// if(number >= 100&&number <= 999)


if (number < 0)
    number = -number;
if (number < 100)
    Console.WriteLine("третьей цифры нет");

else
    Console.WriteLine(result);

int Result(int num)
{
    int result = number;
    if (result < 0)
    result = -result;
    while (result >= 999)
    {
        result = result / 10;
    }
    return (result = result % 10);
}
