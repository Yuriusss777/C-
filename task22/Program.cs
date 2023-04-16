Console.WriteLine("Введите номер: ");
int number = Convert.ToInt32(Console.ReadLine());

void TableAllSquares(int num)
{
   int index = 1; 
   while (index < number)
   {
    Console.WriteLine($"{index, 3} {index * index, 4}");
    index++;
   }
}


TableAllSquares(number);