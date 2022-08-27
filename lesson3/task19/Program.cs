//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!

//14212 -> нет

//12821 -> да

//23432 -> да


Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine());

int count=1,NumTemp=num;

while (NumTemp/10>0)          // Ввела счетчик количества цифр , чтобы легко менять задачу под семизначные и тд
{
    count++;
    NumTemp=NumTemp/10;
}

if (count>5 || count<5)
{
   Console.WriteLine("Число не является пятизначным");
}
else
{   
    int temp=10000;
    int temp1=10;
    int test,test1,count1=0;
    count=count/2 ;


    for (int i=1;i<=count;i++)
   {
    test=num/temp;
    test1=num%temp1;

    if (test==test1) count1++;

    num=num%temp;
    num=num/temp1;

    temp=temp/100;

   }

if (count1==2)   //сount1=(длина строки/2)
    
{
    Console.WriteLine("да");
}
else
Console.WriteLine("нет");   

   
}