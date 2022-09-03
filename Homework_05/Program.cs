// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray( int size){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// Задали функцию, которая возвращает массив длины size и наполнен случайными числами от 100 до 999.

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// Задали функцию, которая показывает искомый массив.

// int CountPosEl(int[] array){
//     int count = 0;
//     for(int i=0; i < array.Length; i++){
//         if(array[i] % 2 == 0)  count++;
//     }
//     return count;
// }
// Задали функцию, которая возвращает счетчик с количеством четных чисел


// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size);
// ShowArray(array);
// Console.WriteLine();
// int posCount = CountPosEl(array);
// Console.WriteLine($"The number of even numbers is {posCount}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray( int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// // Задали функцию, которая возвращает массив длины size и наполнен случайными числами от min до max.

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// // Задали функцию, которая показывает искомый массив.

// int CountEl(int[] array){
//     int sum = 0;
//     for(int i=1; i < array.Length; i+=2){
//         sum += array[i];
//     }
//     return sum;
// }
// // Задали функцию, которая возвращает сумму элементов массива, расположенных на нечентых позициях.

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// Console.WriteLine();
// int countSum = CountEl(array);
// Console.WriteLine($"The sum of the elements is {countSum}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// double[] CreateRandomArray(int size, int min, int max){
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// // Задали функцию, которая возвращает массив длины size и наполнен случайными числами от min до max.

// void ShowArray(double[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// // Задали функцию, которая показывает искомый массив.

// double MaxEl(double[] array){
//     double count = array[0];
//     for(int i=0; i < array.Length; i++){
//         if (count < array[i])
//         count = array[i];
//     }
//     return count;
// }

// double MinEl(double[] array){
//     double count = array[0];
//     for(int i=0; i < array.Length; i++){
//         if (count > array[i])
//         count = array[i];
//     }
//     return count;
// }
// // Задали функции, находящие максимальный элемент массива и минимальный соответственно.

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] array = CreateRandomArray(size, min, max);
// ShowArray(array);

// Console.WriteLine($"Min element is {MinEl(array)}");
// double arraymin = MinEl(array);
// Console.WriteLine($"Max element is {MaxEl(array)}");
// double arraymax = MaxEl(array);

// double res = arraymax - arraymin;
// Console.WriteLine($"Difference is {res}");

