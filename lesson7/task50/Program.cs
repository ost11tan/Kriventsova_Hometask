//Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет




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

int SeаrchNumber(int[,] array, int num)  //уверена,что можно было проще организовать break,но при перемещениях оператора между скобками либо не заходил на вторую строку,если элемента не было на первой,либо все равно выводил все
{
    int flag = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                flag++;
                Console.WriteLine($"i={i},j={j}");
            }
            if (flag > 0)
            {
                break;
            }
        }
        if (flag > 0)
        {
            break;
        }
    }
    return flag;
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

Console.WriteLine("Введите искомое число: ");
int numer = int.Parse(Console.ReadLine());

if (SeаrchNumber(myArray, numer) == 0)
{
    Console.WriteLine("Такого числа нет");
}
