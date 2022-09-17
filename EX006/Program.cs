// НАйти точку пересечения 2х прямых, заданных уравнением y = k1*x+b1, y = k2*x+b2, b1 k1 и b2 k2 заданы

int Coord(int n)
{
    return n = new Random().Next(-10,10);
}
int n = 0;
int b1 = Coord(n);
int b2 = Coord(n);
int k1 = Coord(n);
int k2 = Coord(n);
Console.WriteLine($"k1 = {k1}; b1 = {b1}; k2 = {k2}; b2 = {b2}");
double x = (b2 - b1) / (k1 - k2);
double y = k1*x+b1; 
if(k1*x+b1 == k2*x+b2) Console.WriteLine($"Точка пересечения 2х прямых ({x}; {y})");
else Console.WriteLine("Прямые не пересекаются");

