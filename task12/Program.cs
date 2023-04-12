int firstNumber = new Random().Next(0, 1000);
Console.WriteLine($"первое число -> {firstNumber}");
int secondNumber = new Random().Next(0, 1000);
Console.WriteLine($"второе число -> {secondNumber}");

int theRemainderOfTheDivision = TheRemainderOfTheDivision(firstNumber);
if(theRemainderOfTheDivision == 0)
Console.WriteLine("-> кратно");
else
Console.WriteLine($"->не кратно, остаток {theRemainderOfTheDivision}");

int TheRemainderOfTheDivision(int num)
{
    int theRemainderOfTheDivision = firstNumber %secondNumber;
    return theRemainderOfTheDivision;
}






