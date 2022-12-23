//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


void NumberDiv(int num)
{
    if (num > 99)
    {
        int counter = 0;
        for (int i = num; i != 0; i = i / 10)
        {
            counter++;
        }

        int[] numberSet = new int[counter];

        for (int x = num; x != 0; x = x / 10)
        {
            numberSet[counter - 1] = x;
            counter--;
        }
        Console.WriteLine(num + " -> " + (numberSet[2] % 10));
    }
    else
    {
        Console.WriteLine(num + " -> третьей цифры нет");
    }
}

Console.Write("Введите число - ");
int num = int.Parse(Console.ReadLine());
NumberDiv(num);