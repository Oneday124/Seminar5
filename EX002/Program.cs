// Написать программу преобразования десятичного числа в двоичное
void PrintArray(int[] array)
{
    foreach(int element in array)
    Console.Write($"{element} ");
}

int LenghtArray(int num)
{
int i = 0;
while(num / 2 > 0)
{
    i++;
    num = num / 2;
}
int lenght = i+1;
return lenght;
}

Console.WriteLine("Введите чило: ");
int num = int.Parse(Console.ReadLine() ??"0");

int lenght = LenghtArray(num);
int[] Turn(int[] array)
{
    int[] arr = new int[lenght];
    for(int i = lenght -1; i >= 0; i = i - 1)
        arr[i] = array[i];
    return arr;
}

int[] array = new int[lenght];
int i = 0;
while(num > 0)
{
    array[i] = num % 2;
    num = num / 2;
    i++;
}

int[] arr = Turn(array);
PrintArray(arr);