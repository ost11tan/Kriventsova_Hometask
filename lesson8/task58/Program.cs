//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//
//18 20
//15 18



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


int[,] Multiplication(int[,] array1, int[,] array2)
{
    int m = array1.GetLength(0);
    int n = array2.GetLength(1);
    int[,] result = new int[m, n];
    

    if (m!=n)
    {
        Console.WriteLine("Матрицы невозможно перемножить");
        
    }
    else
    {
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    }
    return result;
}

Console.WriteLine("Введите количество строк первой матрицы:");
int m1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первой матрицы:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы:");
int m2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второй матрицы:");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапазон: ");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

int[,] matrix1 = GetArray(m1, n1, min, max);
Console.WriteLine("Матрица 1:");
PrintArray(matrix1);
Console.WriteLine();

int[,] matrix2 = GetArray(m2, n2, min, max);
Console.WriteLine("Матрица 2:");
PrintArray(matrix2);
Console.WriteLine();


PrintArray( (Multiplication(matrix1,matrix2)));