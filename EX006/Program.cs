// НАйти точку пересечения 2х прямых, заданных уравнением y = k1*x+b1, y = k2*x+b2, b1 k1 и b2 k2 заданы
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1*x+b1; 
    if(k1*x+b1 == k2*x+b2) Console.WriteLine($"Точка пересечения 2х прямых ({x}; {y})");
    else Console.WriteLine("Прямые параллельны или совпадают друг с другом");
}

double b1 = 2;
double k1 = 5;
double b2 = 4;
double k2 = 9;

Console.WriteLine($"k1 = {k1}; b1 = {b1}; k2 = {k2}; b2 = {b2}");
IntersectionPoint(b1, k1, b2, k2);
