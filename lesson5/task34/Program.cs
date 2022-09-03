//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2




int [] RandomArray(int n)
{
    
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return  array;
}

int Count(int [] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0)
        count++;

    }
    return count;
}



Console.WriteLine("Введите число элементов: ");
int N = int.Parse(Console.ReadLine());

int[] myArray = RandomArray(N);
int result = Count(myArray);

Console.WriteLine(String.Join(" ",myArray));
Console.WriteLine($"Количество четных элементов= {result}");
