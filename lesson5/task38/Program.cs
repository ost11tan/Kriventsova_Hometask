//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76



double [] RandomArray(int n,int a,int b)
{

    double[] array = new double[n];
    if (a>b)
    {
        int temp=a;
        a=b;
        b=temp;
    }
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(a,b+1);
        array[i]=array[i]/100   ; 
    }

    return  array;
}


double diffMaxMin(double [] arr)
{   
    double Max=arr[0];
    double Min=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]>Max)
        {
            Max=arr[i];
        }
        else
        {
            if (arr[i]<Min)
            Min=arr[i];
        }
    }
    double diff=Max-Min;
    return diff;

}


Console.WriteLine("Введите число элементов: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите два любых целых числа: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

double[] myArray = RandomArray(N,A,B);
double result = diffMaxMin(myArray);

Console.WriteLine(String.Join(" ",myArray));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива= {result:f2}");