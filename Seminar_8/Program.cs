// int[,] CreateRandom2dArray(int rows, int cols){
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(0, 10);
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

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int [,] ChangeRows(int[,] array){
    int temp = 0;
    for (int j = 0; j<array.GetLength(1); j++){
        temp = array[0, j];
        array[0, j] = array[array.GetLength(0)-1, j];
        array[array.GetLength(0)-1, j] = temp;
    }
    return array;
}


Console.Write("Input numb of m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of n: ");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateRandom2dArray (rows, cols);
Show2dArray(array);
Console.WriteLine();
int[,] array2 = ChangeRows(array);
Show2dArray(array2);


// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] CreateRandom2dArray(int rows, int cols){
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(0, 10);
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

// int[,] Revers2dArray (int [,] array){
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = i + 1; j < array.GetLength(1); j++){
//             temp = array[i,j];
//             array[i,j] = array[j,i];
//             array[j,i] = temp;   
//             }
//         }   
//     return array;
// }


// Console.Write("Input numb of m: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateRandom2dArray(rows, cols);
// Show2dArray(array);
// Console.WriteLine();
// if (array.GetLength(0) == array.GetLength(1)){
//     int[,] array2 = Revers2dArray(array);
//     Show2dArray(array2);
// }
// else Console.WriteLine("Matrix not a quadrat");





// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец 
// (заменить строку и столбец числа 0) на пересечении которых расположен наименьший элемент массива. (заменить числа нулями)


// int[,] CreateRandom2dArray(int rows, int cols){
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(0, 10);
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

// int ChangeColsRows( int [,] array){
//     int iMin = 0;
//     int jMin = 0;
//     for (int i = 0; i<array.GetLength(0); i++){
//         for (int j = 1; j < array.GetLength(1); j++){
//             if (array[i,j] < array[iMin, jMin]){
//                 iMin = i;
//                 jMin = j;
//             }
//         }
//     }
//     for(int j=0; j<array.GetLength(1); j++){
//         array[iMin, j] = 0;
//     }
//     for(int i=0; i<array.GetLength(0); i++){
//         array[i, jMin] = 0;
//     }
//     return array;
// }


// Console.Write("Input numb of m: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateRandom2dArray(rows, cols);
// Show2dArray(array);
// Console.WriteLine();
// int[,] array2 = ChangeColsRows(array2);
// Show2dArray(array2);