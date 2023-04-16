Console.WriteLine("Введите номер четверти оси координат: ");
int quarter = Convert.ToInt32(Console.ReadLine());


string coordinatAxis = CoordinatAxis(quarter);
Console.WriteLine(coordinatAxis == null ? "Неправильный номер четверти" : coordinatAxis);

string CoordinatAxis(int q)
{
    if (quarter == 1) return "x > 0 && y > 0";
    if (quarter == 2) return "x < 0 && y > 0";
    if (quarter == 3) return "x < 0 && y < 0";
    if (quarter == 4) return "x > 0 && y < 0";
    return null;
}
