//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07







int[,] GetArray(int n)
{
    int count = 1;
    int[,] result = new int[n, n];
    int startI = 0;
    int endI = n-1;
    int startJ = 0;
    int endJ = n-1;

    while (startI <= endI && startJ <= endJ)
        {
        for (int j = startJ; j <=endJ; j++)
        {
            result[startI, j] = count;
            count++;
        }
        startI++;//1

        for (int i = startI; i <= endI; i++)
        {
            result[i, endJ] = count;
            count++;
        }
        endJ--;//3
        for (int j = endJ; j >= startJ; j--)
        {
            result[endI, j] = count;
            count++;
        }
        endI--;
        for (int i = endI; i >=startI; i--)
        {
            result[i, startJ] = count;
            count++;
        }
        startJ++;
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

Console.WriteLine("Введите количество элементов:");
int N = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(N);
PrintArray(myArray);
Console.WriteLine();
