// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Программа работает как для отрицательных, так и для положительных чисел.

Console.Write("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

if ((x > -99 && x < 99) || (x < -999 || x > 999))
{
    Console.Write("Введено неверное число");
}
else
{
    int result = (x / 10) % 10;
    Console.Write($"Вторая цифра числа: {Math.Abs(result)}");
}