// Выяснить являются ли числа сторонами треугольника

Console.WriteLine("Введите число1: ");
int a = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("Введите число2: ");
int b = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("Введите число3: ");
int c = int.Parse(Console.ReadLine() ??"0");

if((a + b > c) & (a + c > b) & (b + c > a)) Console.WriteLine($"{a}, {b}, {c} могут являться сторонами треугольника");
else Console.WriteLine($"{a}, {b}, {c} не могут являться сторонами треугольника");