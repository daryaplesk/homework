// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Input(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

(double, double) FindIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    return (Math.Round(x, 1), Math.Round(y, 1));
}

double b1 = Input("Введите b1: ");
double k1 = Input("Введите k1: ");
double b2 = Input("Введите b2: ");
double k2 = Input("Введите k2: ");
System.Console.Write($"Точка пересечения двух прямых: {FindIntersection(b1, k1, b2, k2)}");