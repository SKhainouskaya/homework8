/* //54: Задайте двумерный массив. Напишите программу, которая//
//упорядочит по убыванию элементы каждой строки двумерного массива//

void CreateArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}
void PrintInt2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintInt3(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"array[{i}, {j}, {k}] = {array[i, j, k]}");
            }
        }
    }
}


void InsertSort(int[,] mas)  
    {
    int key = 0;
    int temp = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
     {
        for (int j = 0; j < mas.GetLength(1) - 1; j++)
        {
            key = j + 1;
            temp = mas[i, key];
            for (int k = j + 1; k > 0; k--)
            {
            if (temp > mas[i, k - 1])
            {
                mas[i, k] = mas[i, k-1];
                key = k - 1;
            }
            }
            mas[i, key] = temp;
        }
    }
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m,n];
CreateArray2(array);
PrintInt2(array);
 InsertSort(array);
 PrintInt2(array);
 */



/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
// */

/*  void CreateArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}
void PrintInt2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintInt3(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"array[{i}, {j}, {k}] = {array[i, j, k]}");
            }
        }
    }
}
Console.Write("Введите количество строк массива: ");
 int m2 = int.Parse(Console.ReadLine());
 Console.Write("Введите количество столбцов массива: ");
 int n2 = int.Parse(Console.ReadLine());
 int[,] array2 = new int[m2,n2];
 CreateArray2(array2);
 PrintInt2(array2);
 int sum = 999999999;
 int minSumI = -1;
 for (int i = 0; i < array2.GetLength(0); i++)
 {
     int sumRow = 0;
     for (int j = 0; j < array2.GetLength(1); j++)
     {
         sumRow += array2[i,j];
     }
     if (sumRow < sum)
     {
         sum = sumRow;
         minSumI = i;
     }
 }
 Console.WriteLine("Строка с наименьшей сумоой элементов: " + minSumI);  */

/////////////////
/* 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

void CreateArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}
void PrintInt2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintInt3(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"array[{i}, {j}, {k}] = {array[i, j, k]}");
            }
        }
    }
}

Console.Write("Введите количество строк массива 1: ");
 int m3 = int.Parse(Console.ReadLine());
 Console.Write("Введите количество столбцов массива 1: ");
 int n3 = int.Parse(Console.ReadLine());
 int[,] array3 = new int[m3,n3];
 CreateArray2(array3);
 PrintInt2(array3);

 Console.Write("Введите количество строк массива 2: ");
 int m4 = int.Parse(Console.ReadLine());
 Console.Write("Введите количество столбцов массива 2: ");
 int n4 = int.Parse(Console.ReadLine());
 int[,] array4 = new int[m4,n4];
 CreateArray2(array4);
 PrintInt2(array4);

