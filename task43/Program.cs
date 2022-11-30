// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double CalculationCoordX(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    x = Math.Round(x, 1);
    return x;
}
double x = CalculationCoordX(b1, k1, b2, k2);


double CalculationCoordY(double b1, double k1, double b2, double k2)
{
    double y = k2 * x + b2;
    y = Math.Round(x, 1);
    return y;
}

double y = CalculationCoordY(b1, k1, b2, k2);
if(b1 == b2) Console.Write("Прямые не пересекаются.");
else Console.Write($"Точка пересечения -> (x = {x}; y = {y}).");
