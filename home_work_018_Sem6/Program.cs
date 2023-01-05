// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double k1 = ReadNumber("Введите значение k1 - ");
double b1 = ReadNumber("Введите значение b1 - ");
double k2 = ReadNumber("Введите значение k2 - ");
double b2 = ReadNumber("Введите значение b2 - ");


if (CheckingCoefficient(k1, k2, b1, b2).Item1 == true)
{
    Console.WriteLine(GetIntersectionsOfStraightLines(k1, k2, b1, b2));
}
if (CheckingCoefficient(k1, k2, b1, b2).Item1 == false)
{
    Console.WriteLine(CheckingCoefficient(k1, k2, b1, b2).Item2);
}


double ReadNumber(string s)
{
    while (true)
    {
        Console.Write(s);
        string text = Console.ReadLine();
        if (double.TryParse(text, out double number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}


(bool, string) CheckingCoefficient(double k1, double k2, double b1, double b2)
{
    if ((k1 == k2) & (b1 == b2))
    {
        return (false, "Точек пересечений бесконечно много.");
    }
    if (k1 == k2)
    {
        return (false, "Линии перпендикулярны.");
    }
    
    return (true, String.Empty);
}

(double, double) GetIntersectionsOfStraightLines(double k1, double k2, double b1, double b2)
{

    double x = -(b1 - b2) / (k1 - k2);
    x = Math.Round(x, 5);
    double y = (k1 * x) + b1;
    y = Math.Round(y, 5);
    
    if (x == -0) x = 0;
    return (x, y);
}