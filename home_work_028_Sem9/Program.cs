// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 4;
int n = 8;

Console.WriteLine(SumNum(m, n));

int SumNum(int m, int n)
{
    int res = 0;
    if(n >= m )
    {
        res += m;
        m++;
    }
    else
    {
        return res;
    }
    return res + SumNum(m, n);
}