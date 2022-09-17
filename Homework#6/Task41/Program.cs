// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArrayFromCosnsole(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    System.Console.WriteLine();
    return array;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

System.Console.Write("Сколько чисел вы будете вводить? ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayFromCosnsole(size);
System.Console.WriteLine($"Количество положительных чисел: {CountPositive(array)}");