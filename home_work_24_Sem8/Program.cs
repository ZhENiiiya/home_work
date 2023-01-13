// Задайте две матрицы. 
// Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = new int[,]{{2,4},
                            {3,2}};

int[,] matrix2 = new int[,]{{3,4},
                            {3,3}};

ErrorMatrix(matrix1, matrix2);

int[,] MatrixAddition(int[,] mat1, int[,] mat2)
{
    int[,] result = new int[,]{};
    if (mat1.GetLength(1) == mat2.GetLength(0))
    {
        int[,] matrix = new int[mat1.GetLength(0), mat2.GetLength(1)];
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.GetLength(1); j++)
            {
                for (int k = 0; k < mat2.GetLength(0); k++)
                {
                    matrix[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }
        result = matrix;
    }
    else return result = new int [,]{{-1}};
    return result;
}

void ErrorMatrix(int[,] mat1, int[,] mat2)
{
   int[,] matrix = MatrixAddition(mat1, mat2);
   if (matrix[0,0] == -1)
   {
        Console.WriteLine("Задана не согласованная матрица.");
   }
   else
   {
        Print2DArray(MatrixAddition(mat1, mat2));
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