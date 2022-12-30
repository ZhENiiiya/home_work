// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double A = ReadNumber("Введите число A - ");
double B = ReadNumber("Введите число B - ");
Console.WriteLine($"{A}, {B} -> {GetPow(A, B)}");

double GetPow(double num, double pow)
{
    double numPow = num;
    if (pow > 0)
    {

        for (int i = 1; i < pow; i++)
        {
            num = num * numPow;
        }
        return num;
    }
    if (pow < 0)
    {
        for (int i = 0; i >= pow; i--)
        {
            num = num / numPow;
        }
        return  num;
    }
    if (pow == 0)
    {
        return 1;
    }
    else return -1;

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
            Console.WriteLine("Невверный ввод");
        }
    }
}
