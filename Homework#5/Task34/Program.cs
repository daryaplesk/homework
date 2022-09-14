// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

int FindEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result++;
    }
    return result;
}

int size = 15;
int[] array = FillArray(size);
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.Write($"Количество чётных чисел в массиве: {FindEven(array)}");