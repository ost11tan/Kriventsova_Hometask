//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




int[,] FillArray() //Заполнение массива коэффициентов уравнениия
{

    int[,] matrix = new int[2,2];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows,columns]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return matrix;
}

void PrintArray(int[,] matrix)  //вывод массива, для удобства проверки работы программы (одна строка- коэффициеты одного уравнения )
{

    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($" {matrix[rows,columns]}");
        }
        Console.WriteLine();
    }
}

double SearchX(int [,] arr)
{
   // double x= (arr[1,0]-arr[0,0])/(arr[0,1]-arr[1,1]);   при любых значениях выдает 0 (??? почему???)
    double temp1=arr[1,0]-arr[0,0];
    double temp2=arr[0,1]-arr[1,1];
    
    double x=temp1/temp2;
    return x;
}

double SearchY(double x, int [,] array)
{
    double y = array[0,1] * x + array[0,0];
    return y;
}

int Check(int [,] arr)   //попыталась флаг и функцию выразить через bool (bool Check(int [,] arr) и bool flag=0    ), ругался компилятор, сто не может пребразовать инт в бул 
{
    int flag=0;
    if (arr[1,1]==arr[0,1])
    {
        flag=1;
        if(arr[0,0]==arr[1,0])
        Console.WriteLine("Прямые имеют бесконечное количество общих точек"); 
        else
        {
            Console.WriteLine("Прямые не пересекаются");
        }
    }

  return flag;
}




Console.WriteLine("Введите значения b1, k1, b2 и k2 по порядку: "); 

int [,]variable=FillArray();
PrintArray(variable);

if (Check(variable)==0)
{
    double X=SearchX(variable);
    double Y=SearchY(X,variable);
    Console.WriteLine($"Координаты точки:({X:f2};{Y:f2})"); 
}