//Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.

//5, 0, 20 -> [1, 2, 5, 7, 19]
//3, 1, 35 -> [6, 1, 33]




int [] RandomArray(int n,int a,int b)
{
    if (a>b)
    {
        int temp=a;
        a=b;
        b=temp;
    }
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(a,b);
    }
    return  array;
}


void Print(int [] arr,int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($" {arr[i]}");
    } 
}


Console.WriteLine("Введите число элементов: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапазон [a,b): ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

Print(RandomArray(N,A,B),N);

//Console.WriteLine(String.Join(" ",RandomArray(N,A,B)));
