int firstNumber = new Random().Next(0, 1000);
Console.WriteLine($"первое число -> {firstNumber}");
int secondNumber = new Random().Next(0, 1000);
Console.WriteLine($"второе число -> {secondNumber}");

int squareNumber = SquareNumber(firstNumber);
if(squareNumber == secondNumber)
Console.WriteLine("-> да");
else
Console.WriteLine("нет");

int SquareNumber(int num)
{
    int squareNumber = firstNumber * firstNumber;
    return squareNumber;
}
