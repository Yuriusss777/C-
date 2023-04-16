// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Result(number);
if (number < 0)
number = number * -1;
if (number < 10000 || number > 99999)
    Console.WriteLine("Вы ввели не пятизначное число");
    else

Console.WriteLine(result ? "да" : "нет");

bool Result(int num)
{
    int number5 = num % 10;
    int number4 = (num / 10) % 10;
    int number2 = (num / 1000) % 10;
    int number1 = (num / 10000) % 10;
    return (number5 == number1) && (number4 == number2);
}




