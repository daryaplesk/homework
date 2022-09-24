// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateAndFillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 100);
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
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[] SumOfAllRows(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i] += array[i, j];
        }
    }
    return result;   
}

int FindMin(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
            index = i;
        }
    }
    return index + 1;
}

int[,] array = CreateAndFillArray(5, 5);
PrintArray(array);
System.Console.WriteLine("Сумма каждой строки: ");
int[] result = SumOfAllRows(array);
System.Console.WriteLine(string.Join(';', result));
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindMin(result)}");