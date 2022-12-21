// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// double [,] Create2DArray(int rows, int cols)
// {
//     double [,] array = new double[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = Math.Round(new Random().NextDouble()*10, 2); 
//         } 
//     }
//     return array;
// }

// void ShowArray(double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write ($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Enter 2D array rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter 2D array columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// double [,] myarray = Create2DArray(rows, cols);
// ShowArray(myarray);


//  Напишите программу, которая на вход принимает позиции элемента в двумерном 
//  массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// int [,] Create2DArray (int rows, int cols, int min, int max)
// {
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i<rows; i++)
//     {
//         for (int j = 0; j<cols; j++)
//         {
//             array [i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void ShowArray(int [,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// string CheckElement(int [,] array, int r, int c)
// {
//     string v = "Такого элемента нет";
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             if (i == r && j == c)
//             v = $"{array [i,j]}";
//         }
//     }
//     return v;
// }


// Console.Write("Enter 2D array rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter 2D array columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter checking element row index: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter checking element column index: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int [,] myarray = Create2DArray(rows, cols, min, max);
// ShowArray(myarray);
// string result = CheckElement(myarray, r, c);
// Console.WriteLine(result);


// Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.

// int [,] Create2DArray (int rows, int cols, int min, int max)
// {
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i<rows; i++)
//     {
//         for (int j = 0; j<cols; j++)
//         {
//             array [i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void ShowArray(int [,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Average (int[,] array)
// {
//     double sum = 0;
//     for (int j = 0; j<array.GetLength(1); j++)
//     {
//         sum = 0;
//         for (int i = 0; i<array.GetLength(0); i++)
//         {
//             sum = sum + array[i,j];
//         }
//         Console.WriteLine($"Среднее арифметическое столбца {j+1} = {Math.Round (sum/array.GetLength(0), 1)}");
//     }
// }

// Console.Write("Enter 2D array rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter 2D array columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] myarray = Create2DArray(rows, cols, min, max);
// ShowArray(myarray);
// Average(myarray);