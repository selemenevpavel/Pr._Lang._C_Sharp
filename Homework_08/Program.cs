// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray(int rows, int cols){
//     double [,] array = new double[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(-10, 11);
//     return array;
// }

// void Show2dArray( double[,] array){
//     for (int i = 0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for (int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//     }
//     Console.WriteLine();
// }
// Console.Write("Input numb of m: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// double [,] array = CreateRandom2dArray(rows, cols);
// Show2dArray(array);

//--------------------------------------------------------------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray(int rows, int cols){
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(0, 10);
//     return array;
// }

// void Show2dArray(int [,] array){
//     for (int i = 0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for (int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine("Введите позицию элемента ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = Convert.ToInt32(Console.ReadLine());
//     if (a < array.GetLength(0) && b < array.GetLength(1)){
//         object c = array.GetValue(a, b);
//         Console.WriteLine("Искомое число " + c);
//     }
//     else  {
//         Console.WriteLine("Такого числа в массиве нет");
//     }
// }

// Console.Write("Input numb of m: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateRandom2dArray(rows, cols);
// Show2dArray(array);

//--------------------------------------------------------------------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRandom2dArray(int rows, int cols){
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(0, 11);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for (int i = 0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for (int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//     }
//     Console.WriteLine();
// }

// double ShowSumArray(int[,] array){
//     double average = 0;
//     for (int j = 0; j<array.GetLength(1); j++){
//         double sum = 0;
//         Console.WriteLine();
//         for (int i = 0; i<array.GetLength(0); i++){
//             sum += array[i,j];
//             average = sum / array.GetLength(0);
//         }
//     Console.Write($"Среднее арифметическое столбца {j + 1} равно {average}");
//     }
//     Console.WriteLine();
//     return average;
// }

// Console.Write("Input numb of m: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = CreateRandom2dArray(rows, cols);
// Show2dArray(array);
// double average = ShowSumArray(array);