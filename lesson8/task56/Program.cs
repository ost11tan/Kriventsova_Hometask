//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    if (minValue > maxValue)
    {
        int temp = minValue;
        minValue = maxValue;
        maxValue = temp;
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SummInArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        array[i, 0] = summ;
    }
    return array;
}

int MinInArray(int[,] array)
{
    int min=array[0,0];
    int count=0;
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        if (array[i, 0]<min)
        {
            min=array[i,0];
            count=i;
        }
    }
    return count;
}

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапазон: ");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
Console.WriteLine();

myArray = SummInArray(myArray);

int result=MinInArray(myArray);
Console.WriteLine($"Наименьшая сумма элементов в {result+1} строке");


