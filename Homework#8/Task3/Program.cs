// Задача 3. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.

bool CheckNumberInArray(int[,] array, int number)
{
    int check = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                check = 1;
                break;
            }
        }
    }
    return (check == 1);
}

int[,] FillArrayWithNonRepeatingNumbers(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    int temporary = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            do
                temporary = rnd.Next(9, 99);
            while (CheckNumberInArray(array, temporary) == true);
            array[i, j] = temporary;
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

int[,] array = FillArrayWithNonRepeatingNumbers(3, 3);
PrintArray(array);