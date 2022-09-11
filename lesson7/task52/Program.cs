//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.





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

void AverageColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;                                        //если оставить int,то отбрасывает остаток при выводе переменной average
        double rows = array.GetLength(0);                       //если оставить int,то отбрасывает остаток при выводе переменной average
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
        }
        double average = summ / rows;
        Console.Write($"{average:f3}\t");
    }
}

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапазон: ");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
Console.WriteLine();

AverageColumn(myArray);
