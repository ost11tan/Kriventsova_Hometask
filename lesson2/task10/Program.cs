﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1




Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine());



if   ((num <-999|| num>999) || (num>-100 && num<100))
{
    Console.WriteLine("Число не является трехзначным");
}
else
{
  num = num / 10;
  num = num % 10;
  if (num < 0) 
  {
    num= -1 * num;
  }
  Console.WriteLine($"Вторая цифра заданного числа:{num}");
  
}


