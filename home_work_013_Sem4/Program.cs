// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] newArray = CreateArray();
PrintArray(newArray);

void PrintArray(int[] x)
{
    Console.Write("[");
    for (int i = 0; i < x.Length - 1; i++)
    {
        Console.Write(x[i] + ", ");
    }
    Console.Write(x[x.Length - 1] + "]");
}


int[] CreateArray()
{
    int[] array;
    array = new int[ReadNumber("Введите длину массива - ")];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber($"Введите число кторое хотие сохранить под индексом {i} -> ");
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
            Console.WriteLine("Невверный ввод");
        }
    }
}