//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//2 решения (с массивами и без )




int [] FillArray(int n)
{
    
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return  array;
}


int Counter(int [] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) count++;
    }
    return count;
}


int Variant2(int n)
{
    Console.WriteLine("Введите еще раз элементы по одному: ");
    int counter=0;
    for (int i = 1; i < n+1; i++)
    {
        int number = int.Parse(Console.ReadLine());
        if (number>0) counter++;
    }
    return counter;
}





Console.WriteLine("Введите число элементов: ");
int N = int.Parse(Console.ReadLine());



Console.WriteLine("Введите элементы по одному: ");
int [] myArray = FillArray(N);
Console.WriteLine($"Kоличество элементов больше 0 = {Counter(myArray)}");


Console.WriteLine($"Kоличество элементов больше 0 = {Variant2(N)}");