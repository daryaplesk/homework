// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbersFromMToN(int M, int N)
{
    int i = -1;
    if (M > N) i = 1;
    if (M == N)
        return M;
    return M + SumNumbersFromMToN(M - i, N);
}

int M = 1;
int N = 15;
System.Console.WriteLine(SumNumbersFromMToN(M, N));