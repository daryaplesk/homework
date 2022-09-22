// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int InputData(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArrayRandomly(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
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

void FindArrayElement(int[,] array, int row, int column)
{
    if (row >= array.GetLength(0) || column >= array.GetLength(1))
        System.Console.WriteLine("Такого числа в массиве нет");
    else 
        System.Console.WriteLine($"array[{row}, {column}] = {array[row, column]}");
}

int[,] array = FillArrayRandomly(5, 5);
PrintArray(array);
int row = InputData("Введите номер строки: ");
int column = InputData("Введите номер столбца: ");
if (row < 0 || column < 0) 
    System.Console.WriteLine("Введены некорректные данные");
else
    FindArrayElement(array, row, column);