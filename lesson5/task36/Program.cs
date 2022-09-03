//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0




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
        array[i] = new Random().Next(a,b+1);
    }
    return  array;
}

int Summ (int [] arr)
{
    int sum=arr[1];
    for (int i = 3; i < arr.Length; i++)   ///если делать for (int i = 3; i <= arr.Length; i=i=2),то получается переполнение массива
    {
        if (i%2==1)
        sum+=arr[i];
    }
    return sum;
}







Console.WriteLine("Введите число элементов: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапазон [a,b]: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

int [] myArray=RandomArray(N,A,B);
Console.WriteLine(String.Join(" ",myArray));

int result = Summ(myArray);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях={result}");


