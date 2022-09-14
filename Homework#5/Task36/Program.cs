// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}

int FindOddSumm(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

int size = 6;
int[] array = FillArray(size);
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.Write($"Cумма элементов, стоящих на нечётных позициях: {FindOddSumm(array)}");