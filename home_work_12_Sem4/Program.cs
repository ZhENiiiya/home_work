// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = ReadNumber("Введит число - ");
int result = GetNumSum(number);

Console.WriteLine($"{number} -> {result}");
            
int GetNumSum(int number)
{
    if(number == 0) return number;
    
    int[] arrayNum;
    int counter = 0;
    int div = 10;
    for (int i = number; i != 0; i = i /10)
    {
        counter++;
    }
    arrayNum = new int[counter];

    for(int i = counter -1; i >= 0; i--)
    {
        int x = number % div;
        arrayNum[i] = x;
        number = number / div;
    }
    number = arrayNum[0];
    for(int i = 1; i < arrayNum.Length; i++)
    {
        number = number + arrayNum[i];
    }
    
    
    return number;
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
            Console.WriteLine("Невверный ввод");
        }
    }
}
