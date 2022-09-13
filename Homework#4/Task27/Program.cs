// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Input(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummDigits(int x)
{
    x = Math.Abs(x);
    int result = 0;
    while (x > 0)
    {
        result = result + (x % 10);
        x = x / 10;
    }
    return result;
}

int x = Input("Введите число: ");
System.Console.Write(SummDigits(x));