// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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
            Console.WriteLine("Невверный ввод");
        }
    }
}

int num = ReadNumber("Введите число - ");
Console.Write(num + " -> ");

for (int i = 1; i <= num; i++)
{
    Console.Write(i*i*i + " ");
}