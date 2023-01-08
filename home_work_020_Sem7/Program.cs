// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] array = new int[,]{ {1, 4, 7, 2},
                           {5, 9, 2, 3},
                           {8, 4, 2, 4} };

try
{
    int number = ReadInt("Введите номер позиции элемента - ");
    SearchElementArray(array, number);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



void SearchElementArray(int[,] array, int num)
{
    int x = 0;
    if (array.Length < num) Console.WriteLine( num + " -> такого числа в массиве нет");
    else
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (count < num) x = array[i, j]; 
                count++;
            }
        }
        Console.WriteLine(x);
    }
}

int ReadInt (string title)
{
    Console.Write(title);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed) return number;

    throw new Exception("Введены не корректные символы");
}