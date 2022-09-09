// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Input(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FindCube(int x)
{
    if (x > 0)
    {
        for (int i = 1; i <= x; i++)
        {
            double result = Math.Pow(i, 3);
            System.Console.Write(result + " ");
        }
    }
    else
    {
        for (int i = -1; i >= x; i--)
        {
            double result = Math.Pow(i, 3);
            System.Console.Write(result + " ");
        }
    }
    if (x == 0) System.Console.Write("Введено неверное число");
}

int N = Input("Введите число: ");
FindCube(N);