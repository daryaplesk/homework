// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int InputData(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArrayRandomly(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i , j] = new Random().Next(-100, 100);
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

int m = InputData("Введите m: ");
int n = InputData("Введите n: ");

if (m <= 0 || n <= 0) System.Console.WriteLine("Введены некорректные данные");

int[,] array = new int[m, n];
FillArrayRandomly(array);
PrintArray(array);