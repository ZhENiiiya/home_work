// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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

double PointDistans3D()
{
    int[] pointA = new int[3];
    int[] pointB = new int[3];
    int cordinats = 1;
    for (int i = 0; i < pointA.Length; i++)
    {
        pointA[i] = ReadNumber($"Введите {cordinats}-ую позицию кординат точки A - ");
        cordinats++;
    }
    Console.WriteLine();
    cordinats = 1;
    for (int i = 0; i < pointA.Length; i++)
    {
        pointB[i] = ReadNumber($"Введите {cordinats}-ую позицию кординат точки B - ");
        cordinats++;
    }

    double distans = Math.Sqrt( ((pointB[0] - pointA[0]) * (pointB[0] - pointA[0])) 
                                + ((pointB[1] - pointA[1]) * (pointB[1] - pointA[1]))
                                + ((pointB[2] - pointA[2]) * (pointB[2] - pointA[2])) );

    Console.Write($"A({pointA[0]}, {pointA[1]}, {pointA[2]}); B ({pointB[0]}, {pointB[1]}, {pointB[2]}) -> ");
    
    return distans;

}

Console.WriteLine(Math.Round(PointDistans3D(), 2));
