// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

// void Numbers (int num){
//     int result = 1;
//     for (int curr = 1; curr <= num; curr++){
//         result += curr;
//     }
//     Console.WriteLine($"Сумма чисел от 1 до {num} равна {result}");
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Numbers(number);


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

// void Numbers (int num){
//     int result = 1;
//     for (int curr = 1; curr <= num; curr++){
//         result *= curr;
//     }
//     Console.WriteLine($"Произведение чисел от 1 до {num} равно {result}");
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Numbers(number);

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

// int Prog(int a){
//     int result = 0;
//     for (int i = 1; i <= a; a /=10){
//         result++; 
//     }
//     return result;
// }
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Prog(a));

// Напишите программу, которая находит в последовательности от 1 до N все нечетные числа

// void Numbers (int num){
//     for (int i = 1; i <= num; i+=2){
//         Console.Write(i +" ");
        
//     }
    
// }
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Numbers(a);

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

// int[] CreateRandomArray(int size){
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(0,2);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateRandomArray(size));
