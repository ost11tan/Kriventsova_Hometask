//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53



Console.Write("Введите X для A:");
int ax = int.Parse(Console.ReadLine());

Console.Write("Введите Y для A:");
int ay = int.Parse(Console.ReadLine());

Console.Write("Введите Z для A:");
int az = int.Parse(Console.ReadLine());


Console.Write("Введите X для B:");
int bx = int.Parse(Console.ReadLine());

Console.Write("Введите Y для B:");
int by = int.Parse(Console.ReadLine());

Console.Write("Введите Z для B:");
int bz = int.Parse(Console.ReadLine());


double d = Math.Sqrt((ax-bx)*(ax-bx)+(ay-by)*(ay-by)+(az-bz)*(az-bz));

Console.WriteLine($"расстояние = {d:f2}");