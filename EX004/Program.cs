// Показать числа Фибоначи меньше заданного числа N

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine() ??"0");
int i = 0;
int j = 1;
int result = i + j;

Console.WriteLine(i);
Console.WriteLine(j);
while(result + i < N)
{
    result = i + j;
    i = j;
    j = result;
    Console.WriteLine(result);
}


