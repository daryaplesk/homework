// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 100);
    return array;
}

(int, int) FindMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    return (max, min);
}

int size = 10;
int[] array = FillArray(size);
System.Console.WriteLine("[{0}]", string.Join(", ", array));

(int, int) MaxMin = FindMaxMin(array);
System.Console.WriteLine($"{MaxMin.Item1} - {MaxMin.Item2} = {MaxMin.Item1 - MaxMin.Item2}");