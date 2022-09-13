// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Решение через цикл for.

double Input(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(System.Console.ReadLine());
}

double Exponentiate(double x, double y)
{
    double result = x;
    if (y == 0) return 1;
    if (y > 0)
    {
        for (int i = 2; i <= y; i++)
        { 
            result = result * x;
        }
        return result;
    }
    else 
    {
        y = Math.Abs(y);
        for (int i = 2; i <= y; i++)
        { 
            result = result * x;
        }
        return 1 / result;
    }
}

double A = Input("Введите число: ");
double B = Input("Введите степень, в котороую будет возведено число: ");
System.Console.WriteLine($"{A}^{B} = {Exponentiate(A, B)}");