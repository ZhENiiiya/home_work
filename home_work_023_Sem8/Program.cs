// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2D = new int[,]{{1,4,9,9},
                            {5,9,2,3},
                            {8,4,2,4},
                            {5,2,6,7}};

Print2DArray(array2D);
Console.WriteLine();
MinSumElement(array2D);

void MinSumElement(int[,] array)
{
    Dictionary<int, int> list = new Dictionary<int, int>();
    int sum = 0;
    int numStr = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[i,j];
            
        }
        numStr++;
        list.Add(numStr, sum);
        sum = 0;
    }
    var x = list.Min(x => x.Value);
    for (int i = 0; i < list.Count; i++)
    {
        if (x == list.ElementAt(i).Value)
        {
            Console.WriteLine($"Наименьшая сумма элементов находится в строке {list.ElementAt(i).Key}");
        }
    }
    
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}