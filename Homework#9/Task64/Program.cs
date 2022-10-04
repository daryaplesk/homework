// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string GetNumbersFromNTo1(int N)
{
    if (N == 1)
        return 1.ToString();
    return N.ToString() + ", " + GetNumbersFromNTo1(N - 1);
}

int N = 10;
System.Console.WriteLine(GetNumbersFromNTo1(N));