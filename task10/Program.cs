Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Result(number);

if (number < 0)
number = -number; 
if(number >= 100&&number <= 999)
Console.WriteLine(result);

int Result(int num)
{
    return(result = (num / 10)%10);
}