// Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
// Для справки: 
// Как умножать матрицы: https://ru.onlinemschool.com/math/assistance/matrix/multiply/?oms_all=a%3d%7b%7b4,4,5%7d,%7b1,5,2%7d,%7b9,9,7%7d%7d,b%3d%7b%7b5,8,1%7d,%7b4,4,9%7d,%7b5,3,2%7d%7d

int[,] CreateAndFillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 10);
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
    System.Console.WriteLine();
}

int[,] MultiplyMatrices(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

int[,] array1 = CreateAndFillArray(3, 3);
PrintArray(array1);
int[,] array2 = CreateAndFillArray(3, 3);
PrintArray(array2);
int[,] result = MultiplyMatrices(array1, array2);
PrintArray(result);