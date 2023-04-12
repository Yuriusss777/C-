int number = new Random().Next(100, 1000); // 99+1
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
int deleteCenter = DeleteCenter(number);
int DeleteCenter(int num) // num  = number
{
    int first = num / 100;
    int third = num % 10;
    int answer = first * 10 + third;
    return answer;
}

Console.WriteLine($"двузначное число = {deleteCenter}");


// int number = new Random().Next(100, 1000); // 99+1
// Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
// int firstDigit = number / 100;
// int secondDigit = number % 10;
// Console.WriteLine($"первое и третье число = {firstDigit} и {secondDigit}");