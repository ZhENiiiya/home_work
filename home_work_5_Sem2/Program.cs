//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1

// Коде работает, осталось добавить tryParse

int TwoNumber(int number)
{
   int res_number = number % 100 / 10;
   return res_number; 
}


Console.Write("Введите трёхзначное число - ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine( TwoNumber(number));
