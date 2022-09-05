// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// 1 вариант решения

// int[] ReversMass(int[] array){
//     int temp = 0;
//     for (int i = 0; i < array.Length / 2; i++){
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }
// int [] array = {1, 3, 5, 7, 0, 8};
// int [] revMass = ReversMass(array);
// for (int i = 0; i<revMass.Length; i++){
//     Console.Write(revMass[i]+ " ");
// }


// 2 вариант решения

// int[] ReversMass(int[] array){
//     int temp = 0;
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--){
//         temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
//     return array;
// }
// int [] array = {1, 3, 5, 7, 0, 8};
// int [] revMass = ReversMass(array);
// for (int i = 0; i<revMass.Length; i++){
//     Console.Write(revMass[i]+ " ");
// }


// 3 вариант решения

// int[] ReversMass(int[] array){
//     int temp = 0;
//     int i = 0;
//     int j = array.Length - 1;
//     while(i < j){
//         temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//         i++;
//         j--;
//     }
//     return array;
// }
// int [] array = {1, 3, 5, 7, 0, 8};
// int [] revMass = ReversMass(array);
// for (int i = 0; i<revMass.Length; i++){
//     Console.Write(revMass[i]+ " ");
// }

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// string ChangeDigitSystem (int n){
//     string result = string.Empty; // присвоили стрингу пустое значение
//     while(n > 0){
//         result = n % 2 + result;
//         n /= 2;
//     }
//     return result;
// }
// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string res = ChangeDigitSystem(n);
// Console.WriteLine(res);


// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// void Numbers (int a, int b, int c){
//     if (a+b>c && a+c>b && b+c>a) Console.WriteLine ("Отличный треугольник");
//     else Console.WriteLine("Треугольник не получится");
// }
// Console.WriteLine("Сторона а: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сторона b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сторона c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Numbers(a, b, c);


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int[] Fibon(int n){
    int[] array = new int[n];
    array[0]=0;
    array[1]=1;
    for(int i=2; i<n; i++){
       array[i] = array[i-2] + array[i-1]; 
    }
    return array;
}

void ShowArray(int[] array){                             
    for(int i = 0; i<array.Length; i++){
    Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibon(n));
Console.WriteLine();
