// Написать программу преобразования десятичного числа в двоичное (решение через строки)

Console.WriteLine("Введите чило: ");
int num = int.Parse(Console.ReadLine() ??"0");

string result = String.Empty;

while (num > 0)
{
    result = Convert.ToString(num % 2) + result;
    num = num / 2;
}
Console.WriteLine(result);

