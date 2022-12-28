// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Polindrom(string s)
{
    int number;
    while (true)
    {
        Console.Write(s);
        string text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        else
        {
            Console.WriteLine("Неыерный ввод");
        }
    }

    int counter = 0;
    int div = 1;
    for (int i = number; i != 0; i = i / 10)
    {
        counter++;
        div = div * 10;
    }
    div = div / 10;
    counter = counter /2;
    string t = "Нет";

    Console.Write(number + " -> ");
    while (counter > 0)
    {
        if (number / div == number % 10)
        {
            number = (number % div) / 10;
            div = div / 100;
            t = "Да";
        }
        else
        {
            t = "Нет";
        }
        counter--;
    }
    Console.WriteLine(t);


}
Polindrom("Введите число для проверки - ");
