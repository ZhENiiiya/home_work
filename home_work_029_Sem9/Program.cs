// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = ReadNumber("Введите m: ");
int n = ReadNumber("Введите n: ");

Console.WriteLine($"A(m, n) = {FunctionsAck(m, n)}");

int FunctionsAck(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionsAck(m - 1, 1);
  else return FunctionsAck(m - 1, FunctionsAck(m, n - 1));
}

int ReadNumber(string s)
{
    while (true)
    {
        Console.Write(s);
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}