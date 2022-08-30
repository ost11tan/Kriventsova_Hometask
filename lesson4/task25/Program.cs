//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16






double Pow(int number, int pow)
{
    double result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result*=number;
    }
    return result;
}



Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

if (B<0)
{
    Console.WriteLine($"Нужно извлечь корень,без библиотеки сделать это не могу");
}
else
    Console.WriteLine($"{Pow(A,B)}");