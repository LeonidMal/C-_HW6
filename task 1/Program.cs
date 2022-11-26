 /*Напишите программу, которая найдёт точку пересечения двух прямых, 
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double Readdouble(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = Readdouble("Введите первое число: ");
double k1 = Readdouble("Введите второе число: ");
double b2 = Readdouble("Введите третье число: ");
double k2 = Readdouble("Введите четвертое число: ");

double x = PointX (k1, b1, k2, b2);
double y = PointY (k2, b2, x);

double PointX (double a, double b, double c, double d)
{
    double x = (b - d) * -1 / (a - c);
    return x;
}

double PointY (double c, double d, double e)
{
    double y = c * e + d;
    return y;
}

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
