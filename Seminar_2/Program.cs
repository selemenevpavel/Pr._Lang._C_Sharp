// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа

// int CutNumber(){
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine("Number is - " + num);
//     int dec = num / 100;
//     int ed = num % 10;
//     int result = dec * 10 + ed;
//     return result;
// } 

// int number = CutNumber();
// Console.WriteLine("Cut number is - " + number);


// void CutNumber(){
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine("Number is - " + num);
//     int dec = num / 100;
//     int ed = num % 10;
//     int result = dec * 10 + ed;
//     Console.WriteLine("Cut number is - " + result);
// } 
// CutNumber();
// 

//Нахождение произведения двух факториалов

// int Factorial(int num){
//     int current = 1;
//     int fact = 1;
//     while (current <= num)
//     {
//         fact *= current;
//         current++;
//     }
//     return fact;
// }

// int result = Factorial(12) * Factorial(10);
// Console.WriteLine("Your resalt is - " + result);

// напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа

// int Line(){
//     int num = new Random().Next(10, 100);
//     Console.WriteLine("Number is - " + num);
//     int dec = num / 10;
//     int ed = num % 10;
//     if (dec > ed){
//         return dec;
//     }
//     else {
//         return ed;
//     }
// } 
// Console.WriteLine("Result - " + Line());


// Напишите программу, которая принимает на вход число и проверяет
// кратно ли оно одновременно 7 и 23

// void a(){
//     Console.Write("Введи число - ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     if ((a % (7 * 23)) == 0){
//         Console.WriteLine("Отлично");
//     }
//     else {
//         Console.WriteLine("Ищи другое число");
//     }
// }
// a();

// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого

// void Square(int a, int b)
// {
//     if (a == b * b || b == a * a)
//     {
//         Console.WriteLine("Условие выполняется");
//     }
//     else
//     {
//         Console.WriteLine("Условие не выполняется");
//     }
// }
// Console.Write("Введи число 1 - ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи число 2 - ");
// int b = Convert.ToInt32(Console.ReadLine());
// Square(a, b);

//3 Задача - Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.


// int Square(int a, int b){
    
//     if(b % a != 0){
//         int result = b % a;
//         return result;
//     }
//     else{
//         return 0;
//     }
// }

// Console.Write("Enter the number 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a==0 || b==0){
//     Console.WriteLine("На ноль делить нельзя!");
// }
// else{
//     int result = Square(a,b);
//     if(result == 0){
//         Console.WriteLine("Второе число кратно первому");
//     }
//     else{
//         Console.WriteLine("Второе число не кратно первому.Остаток от деления: " + result);
//     }
// }

