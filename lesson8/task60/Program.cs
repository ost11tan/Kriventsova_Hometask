﻿//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)




//проверка на x *y*z <90

bool InArray(int[,,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if(arr[i,j,k]==number) return true;
            }
        }
    }
     return false;
}

int[,,] GetArray(int x, int y, int z)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                while (true)
                {
                    int temp = new Random().Next(10,100);

                    if (!InArray(result, temp))
                    {
                        result[i, j, k] = temp;
                        break;
                    }

                }
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
            }
        }
        Console.WriteLine();
    }
}




Console.WriteLine("Введите количество значений по оси X:");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество значений по оси Y");
int Y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество значений по оси Z");
int Z = int.Parse(Console.ReadLine());


int[,,] myArray = GetArray(X, Y, Z);
PrintArray(myArray);

Console.WriteLine();




