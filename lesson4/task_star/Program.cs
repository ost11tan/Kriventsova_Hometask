//Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());


void Print1(int n) //печатаем звездочки стройой
{

    for (int i = 1; i <= n; i++)    
    {
        Console.Write(" * ");
    }
} 
void Print2(int n1) //печатаем пробелы строкой 
{

    for (int j = 1; j <= n1; j++)    
    {
        Console.Write(" . ");
    }
}
void star(int n3)//Алгоритм по увеличению количества звездочек
{
    int count = 1;
    while (count <=n3)
    {
        Console.WriteLine("");  
        Print1(count);
        count=count+2;
    }
}

void spase(int n4) //Алгоритм  по уменьшению пробелов
{
    int count1 = n4;
    while (count1>0)
    {
        Console.WriteLine("");  
        Print2(count1);
        count1=count1-2;
    }
}

    int q=num;
    while (q>0)
    {
        Console.WriteLine("");  
        spase(q);
        star(q);
        q=q-2;
    }
