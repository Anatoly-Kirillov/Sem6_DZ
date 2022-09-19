// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] PointOfCross(double[,] array)
{
    double[] points = new double[2];
    points[0] = (array[1, 1] - array[0, 1]) / (array[0, 0] - array[1, 0]);
    points[0] = Math.Round(points[0], 2);
    points[1] = array[0, 0] * points[0] + array[0, 1];
    points[1] = Math.Round(points[1], 2);
    return points;
}
double[,] line = new double[2, 2];
Console.Write("Введите координату b1: ");
line[0, 1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату k1: ");
line[0, 0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату b2: ");
line[1, 1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату k2: ");
line[1, 0] = Convert.ToInt32(Console.ReadLine());

double[] CrossPoints = new double[2];
if (line[0, 0] == line[1, 0] & line[0, 1] != line[1, 1])
{
    Console.WriteLine("Линии паралельны");
}
else
{
    if (line[0, 0] == line[1, 0] & line[0, 1] == line[1, 1])
    {
        Console.WriteLine("Линии совпадают");
    }
    else
    {
        CrossPoints = PointOfCross(line);
        Console.Write($"({String.Join("; ", CrossPoints)})");
    }
}
