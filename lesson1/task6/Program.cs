// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());

//Тк дробное число не может быть четным,то используем тип int
//Но в таком случае программа выдаст ошибку, если пользователь введет дробное число
//Для этого можно использовать double
//double number = double.Parse(Console.ReadLine());

if (number==0)
Console.WriteLine("Число не является ни четным ни нечетным");
else
{number=number%2;
if (number==0)
Console.WriteLine("Да");
else
Console.WriteLine("нет");
}