//Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
//[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
//[1,2,2,3,2] -> [3, 2, 2, 2, 1]



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

int [] Buble (int [] arr)
{
    for (int k=arr.Length-1;k>0;k--)
    {
        for (int i = 0; i < k; i++)
        {
            if (arr[i]<arr[i+1])
            {
             int temp=arr[i];
             arr[i]=arr[i+1];
              arr[i+1]=temp;
            }
        }
    }
    return arr;
}







Console.WriteLine("Введите число элементов: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапазон [a,b]: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

int [] myArray=RandomArray(N,A,B);
Console.WriteLine(String.Join(" ",myArray));

myArray=Buble(myArray);
Console.WriteLine(String.Join(" ",myArray));
