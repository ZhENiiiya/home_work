using System;
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[] { 3, 7, 22, 2, 78 };

double maxValue = GetMaxValue(array);
double minValue = GetMinValue(array);
Console.WriteLine($"{PrintArray(array)} -> {maxValue - minValue}");

string PrintArray(double[] array)
{
    return ($"[{string.Join(", ", array)}]");
}

double GetMaxValue(double[] array)
{
    double resultMax = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (resultMax < array[i]) resultMax = array[i];
    }
    return resultMax;
}

double GetMinValue(double[] array)
{
    double resultMin = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (resultMin > array[i]) resultMin = array[i];
    }
    return resultMin;
}