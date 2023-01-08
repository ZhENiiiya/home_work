// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int m = ReadDouble("Введите m - ");
int n = ReadDouble("Введите n - ");

double[,] array2d = Create2DArray(m, n);
double[] array = GetTheArithmeticMean(array2d);

Print2DArray(array2d);
Console.WriteLine();
Console.WriteLine(PrintArray(array));


double[] GetTheArithmeticMean(double[,] array2D)
{
    double[] array = new double[array2D.GetLength(1)];
    

    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        double res = 0;
        for (int j = 0; j < array2D.GetLength(0); j++)
        {
            res += array2D[j, i];
            
        }
        array[i] = Math.Round((res / array2D.GetLength(0)), 2);
    }
    return array;
}

string PrintArray(double[] array)
{
    return ($"{string.Join(" ", array)}");
}

void Print2DArray(double[,] array)
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

double[,] Create2DArray(int m, int n)
{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((random.Next(1, 9) + random.NextDouble()));
        }
    }
    return array;
}


int ReadDouble(string title)
{
    Console.Write(title);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed) return number;

    throw new Exception("Введены не корректные символы");
}
