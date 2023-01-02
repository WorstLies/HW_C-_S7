// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите кол-во строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// _________________________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество строк");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns=Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j]= new Random().Next(-100,101);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Console.WriteLine("Введите номер строки искомого элемента");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца искомого элемента");
// int columns1 = Convert.ToInt32(Console.ReadLine());

// if (rows1<=matrix.GetLength(0) && columns1<=matrix.GetLength(1))
// {
//     Console.Write(matrix[rows-1,columns-1]);
// }
// else
// {
//     Console.Write("Такого числа в массиве нет");
// }

// _______________________________________________________________________________________

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

double num = 0;
int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        num+= matrix[i, j];
    }
    num = num / matrix.GetLength(0);
    
    Console.Write($"Среднее арифметическое столбца {j+1}: ");
    Console.WriteLine(Math.Round((num),2));
    
    num = 0;
}