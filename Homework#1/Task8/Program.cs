// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (N < 0) Console.Write("Ошибка. Введите число больше 0.");

while (count <= N)
{
    if (count%2 == 0) Console.Write(count + " ");
    count++;
}