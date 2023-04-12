Console.WriteLine("введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
bool squareNumber = SquareNumber(firstNumber, secondNumber);
Console.WriteLine(squareNumber ? "да" : "нет");

bool SquareNumber(int num1, int num2)
{
    return (num1 == num2 * num2) || (num2 == num1 * num1);
}
