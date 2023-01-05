// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] array = CreateArray();

Console.WriteLine($"{PrintArray(array)} -> {GetPresenceOfPositiveNumbers(array)}");


int GetPresenceOfPositiveNumbers(int[] array)
{
    int positiveNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveNumber++;
    }
    
    return positiveNumber;
}

string PrintArray(int[] array)
{
    return ($"{string.Join(", ", array)}");
}

int[] CreateArray()
{
    int[] array;
    array = new int[ReadNumber("Введите длину массива - ")];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber($"Введите число которое хотите сохранить под индексом {i} -> ");
    }
    return array;
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