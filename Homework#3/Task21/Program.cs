// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Input(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}

int[] InputCoords(int n)
{
    int[] coord = new int[3];
    coord[0] = Input($"Введитe x{n}: ");
    coord[1] = Input($"Введитe y{n}: ");
    coord[2] = Input($"Введитe z{n}: ");
    System.Console.WriteLine();
    return coord;
}

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return Math.Round(distance, 2);
}

int[] coord1 = InputCoords(1);
int[] coord2 = InputCoords(2);

System.Console.WriteLine($"Расстояние между точками: {FindDistance(coord1[0], coord1[1], coord1[2], coord2[0], coord2[1], coord2[2])}");