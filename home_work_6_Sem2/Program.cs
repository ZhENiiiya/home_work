//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Введите число - ");
int num = int.Parse(Console.ReadLine());

if (num > 99)
{
    for (int i = num; i != 0; i = i / 10)
    {
        Console.WriteLine(i);
    }

}
else
{
    Console.WriteLine(num + " третьей цифры нет");
}