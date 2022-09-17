// Написать программу масштабирования фигуры. Что бы задавались вершины фигуры списком (одной строкой). Например, "(0,0) (2,0) (2,2) (0,2)"
// Коэффициент масштабирования k задавался отдельно -2 или 4  или 0,5. В результате показать координаты, которые получаются
// при k = 2. Получаем "(0,0) (4,0) (4,4) (0,4)" 

void PrintImage(int[] matrix, double k)
{
    for (int i = 0; i < matrix.Length; i = i + 2)
    {

        double a = matrix[i];
        double b = matrix[i + 1];
        Console.Write($"({a * k},{b * k}) ");
    }
    Console.WriteLine();
}

int[] matrix = new int[]
{
    0,0,2,0,2,2,0,2
};
PrintImage(matrix, 1);
Console.WriteLine();
Console.WriteLine("Введите коэффициент масштабирования: ");
double n = double.Parse(Console.ReadLine() ?? "0");
PrintImage(matrix, n);

