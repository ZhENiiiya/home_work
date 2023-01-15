// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. 
// Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Print3DArray(CreateArray3D(3, 3, 2, 10, 1000));

int[,,] CreateArray3D(int m, int n, int x, int ranStart, int ranEnd)
{
    int[,,] array3D = new int[m, n, x];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = GenerateUniqueNumber(ranStart, ranEnd);

            }
        }
    }

    return array3D;
}

int GenerateUniqueNumber(int ranStart, int ranEnd)
{
    HashSet<int> number = new HashSet<int>();
    Random r = new Random();
    while (true)
    {
        var n = r.Next(ranStart, ranEnd);
        if (!number.Contains(n))
        {
            number.Add(n);
            return n;
        }
    }

}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}