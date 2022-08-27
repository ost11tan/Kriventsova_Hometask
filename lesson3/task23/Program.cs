//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125



Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num<=0)
{
    Console.WriteLine("Я не смогу вывести число от 1 до N, тк число меньше или равно нулю");
}

for ( int i = 1; i <= num; i++)
{
Console.WriteLine($"{i*i*i}");

}

//Способ через библиотеку

for ( int i = 1; i <= num; i++)
{
double pow = Math.Pow(i,3);
Console.WriteLine($"{pow}");
}




