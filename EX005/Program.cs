// 1 <= l <= 1000 - длинна коридора
// p - скорость заряда Гарри м/с
// q - скорость заряда Воландеморта м/с
// 1 <= p, q <= 500
// Найти Расстояние до места второй встречи испульсов заклинаний, при условии что противники стоят на месте

Console.WriteLine("Введите длинну коридора: ");
double l = double.Parse(Console.ReadLine() ??"0");
if(l < 1 || l > 1001)
Console.WriteLine("Введите число с интервале от 1 до 1000");
Console.WriteLine("Введите скорость полета заряда Гарри: ");
double p = double.Parse(Console.ReadLine() ??"0");
if(p < 1)
Console.WriteLine("Введите число > 1");
Console.WriteLine("Введите скорость полета заряда ВоландеМорта: ");
double q = double.Parse(Console.ReadLine() ??"0");
if(q < 1 || q > 500)
Console.WriteLine("Введите число от 1 до 500");

double t1 = l / (p+q);
double l1 = t1 * p;

Console.WriteLine($"{l1} ");