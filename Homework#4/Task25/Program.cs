// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Решение через Math.Pow.

double Input(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(System.Console.ReadLine());
}

double A = Input("Введите число: ");
double B = Input("Введите степень, в котороую будет возведено число: ");
System.Console.WriteLine($"{A}^{B} = {Math.Pow(A, B)}");