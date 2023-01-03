// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = CreateRandomArray(4, 100, 999);
int result = GetEvenNumbersFromArray(array);
Console.WriteLine($"{PrintArray(array)} -> {result}");

int GetEvenNumbersFromArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}


string PrintArray(int[] array)
{
    return ($"[{string.Join(", ", array)}]");
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int [] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}