//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
// = 4; N = 8. -> 30


int SummElements(int n, int m, int summ)
{
    while (m<n)
    {
        return summ=SummElements(n,m+1,summ+m);
    }

    return summ;
}

Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

if (N < M)
{
    int temp = N;
    N = M;
    M = temp;
}

int Summ = N;
int result = SummElements(N, M, Summ);
Console.WriteLine($"{result}");
