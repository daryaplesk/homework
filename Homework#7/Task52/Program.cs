// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArrayRandomly(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i , j] = new Random().Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i , j] + " ");
        }
        System.Console.WriteLine();
    }
} 

double FindAverageForColumn(int[,] array, int column)
{
    double result = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += array[i, column];
        count++;
    }
    return Math.Round(result / count, 2);
}

string FindAverageForAllColumns(int[,] array)
{
    string result = "";
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result += FindAverageForColumn(array, i) + "; ";
    }
    return result;
}

int[,] array = FillArrayRandomly(3, 3);
PrintArray(array);
System.Console.WriteLine($"Среднее арифметическое каждого столбца: {FindAverageForAllColumns(array)}");