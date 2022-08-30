//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12
/////////////////////////////////////////////////



int Summa(int num)
{
    int NumTemp=num;
    int result=0;

    while (NumTemp/10!=0)        
    {
        result+=NumTemp%10;
        NumTemp=NumTemp/10;
    }
    result+=NumTemp;
    if (result<0)
    {
        result=-result;
    }
    return result;
}




Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{Summa(number)}");