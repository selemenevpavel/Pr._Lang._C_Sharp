// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// void Numbers (int a, int b){
//     int result = 1;                 
//     for (int i = 1; i <= b; i++){   
//         result *= a;
//     }
//     Console.WriteLine($"{a} в степени {b} равно {result}");
// }
//     Задаем функцию, в которой число a умножается на себя i раз, пока i не станет равно b
// Console.WriteLine("Введите число, возводимое в степень: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число, определяющее степень: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Numbers(a, b);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Prog(int a){
//     int result = 0;
//     for (int i = 1; i <= a; a /=10){
//         int b = a % 10;
//         result += b; 
//     }
//     return result;
// }
// задаем функцию, на каждом цикле которой заданное число делим на 10, а остаток суммируем.
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Prog(a));

// Задача 29: Напишите программу, которая задаёт массив из произвольного элементов 
// и выводит их на экран.

// int[] CreateArray(int size, int n){
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(0, n+1);
//     }
//     return array;
// }
// Задаем функцию, в которой определяем длину массива, наполняем его случайными элементами
// и ограничиваем величину максимального значения элемента числом n

// void ShowArray(int[] array){
//     Console.Write("Произвольный массив [");
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + ",");
//     }
//     Console.WriteLine("]");
// }
// Задаем функцию, в которая будет показывать в [] скобках через , элементы массива
// до тех пор, пока не покажет все элементы массива, заданного функцией CreateArray() 

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateArray(size, n));

