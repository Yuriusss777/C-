﻿int number = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

//     if(firstDigit > secondDigit) 
//     {
//     Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");
// }

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа = {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа = {maxDigit}");
int MaxDigit(int num) // num  = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}
