// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// // Задаем двумерный массив, заполненный случайными числами от 0 до 9 включительно
// int[,] CreateRandom2dArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i, j] = new Random().Next(0, 10);
//     return array;
// }
// // Задаем метод, который показывает массив
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//     }
//     Console.WriteLine();
// }
// // Задаем метод, который будет сортировать по убыванию методом пузырька элементы в строках массива
// int[,] SortRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Input numb of m: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateRandom2dArray(rows, cols);
// Show2dArray(array);
// Console.WriteLine();
// Show2dArray(SortRows(array));

//------------------------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// // Задаем двумерный массив, заполненный случайными числами от 0 до 9 включительно
// int[,] CreateRandom2dArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i, j] = new Random().Next(0, 10);
//     return array;
// }
// // Задаем метод, который показывает массив
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//     }
//     Console.WriteLine();
// }

// // Задаем метод, который будет суммировать элементы в строках массива 
// // и выводить номер строки с минимальной суммой
// void SumElementRows(int[,] array)
// {
//     int minRowsIndex = 0;
//     int minSum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumRows = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumRows += array[i, j];
//             if (i == 0)
//             {
//                 minSum = sumRows;
//             }
//             else if (sumRows < minSum)
//             {
//                 minSum = sumRows;
//                 minRowsIndex = i;
//             }
//         }
//     }
//     Console.WriteLine($"Сумма элеменентов минимальна в строке {minRowsIndex + 1}");
// }

// Console.Write("Input numb of m: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateRandom2dArray(rows, cols);
// Show2dArray(array);

// SumElementRows(array);

//-----------------------------------------------------------------------------------------------------------

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Задаем двумерный массив, заполненный случайными числами от 0 до 9 включительно

// Создаем двумерный массив размера 4 на 4
int[,] array = new int[4, 4];

int curr = 1;
int i = 0;
int j = 0;

// до тех пор пока счетчик маньше или равен произведению количества строк на количество столбцов выполнять условия
while (curr <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = curr;
    curr++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++; // заполнение верхней строки
    else if (i < j && i + j >= array.GetLength(0) - 1) i++; // заполнение правого столбца
    else if (i >= j && i + j > array.GetLength(1) - 1) j--; // заполнение нижней строки
    else i--;  // заполнение левого стобца
}

// Задаем метод, который показывает массив
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0) 
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        } // Наводим красоту. Если элемент массива больше 9, то обрамляем его пробелами, 
          // если меньше 9, то пробел ставим после элемента
        Console.WriteLine();
    }
}

Show2dArray(array);