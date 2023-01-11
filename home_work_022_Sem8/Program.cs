// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array2D = new int[,]{ {1, 4, 7, 2},
                            {5, 9, 2, 3},
                            {8, 4, 2, 4} };
Print2DArray(array2D);
Console.WriteLine();
Print2DArray(SortArray2D(array2D));

int[,] SortArray2D(int[,] array2D)
{
    
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            for (int k = 0; k < array2D.GetLength(1)-1; k++)
            {
                if (array2D[i, k] < array2D[i, k+1])
                {
                    int x = array2D[i, k+1];
                    array2D[i,k+1] = array2D[i,k];
                    array2D[i,k] = x;
                }
            }
        }
    }

    return array2D;
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