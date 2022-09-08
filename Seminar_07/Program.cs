// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(min, max + 1);
//     return array;
// }

// void Show2dArray( int [,] array){
//     for (int i = 0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for (int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//     }
//     Console.WriteLine();
// }

// int SumDiag( int [,] array){
//     int sum = 0;
//     if (array.GetLength(0) == array.GetLength(1)){
//         for (int i = 0; i<array.GetLength(0); i++){
//             for (int j = 0; j<array.GetLength(1); j++){  // if (i==i) sum += array[i,i]; написав это строку можно удалить
//                 if (i==j) sum += array[i,j];             // строка выше позволяет уйти от перебора по j
//             }
//         }
//     }
//     return sum;
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// int sum = SumDiag(array);
// Console.WriteLine("Sum of numb " + sum);

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// int[,] CreateRandom2dArray(int rows, int cols){
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(rows + cols, rows + cols + 1);
//     return array;
// }


// void Show2dArray( int [,] array){
//     for (int i = 0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for (int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//     }
//     Console.WriteLine();
// }

// Console.Write("Input numb of m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateRandom2dArray(m,n);
// Show2dArray(array);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты.

int[,] CreateRandom2dArray(int rows, int cols){
    int [,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i,j] = new Random().Next(0, 10);
    return array;
}

void Show2dArray( int [,] array){
    for (int i = 0; i<array.GetLength(0); i++){
        Console.WriteLine();
        for (int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
    }
    Console.WriteLine();
}

int[,] Quadrat(int [,] array){
    int [,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i+2){
        for (int j = 0; j < array.GetLength(1); j+2){
                array[i,j] *= array[i,j];
        }
    }    
    return array;
}


Console.Write("Input numb of m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of n: ");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2dArray(rows, cols);
Show2dArray(array);
int[,] array2 = Quadrat(array);
Show2dArray(array2);

