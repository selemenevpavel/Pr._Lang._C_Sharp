// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// void Func(int num){
//         if (num.ToString()[0] == num.ToString()[4] && num.ToString()[1] == num.ToString()[3]){
//         Console.WriteLine("Ура, это палиндром!");
//     }
//     else {
//         Console.WriteLine("Указанное число не является палиндромом");
//     } 
// }
// Ввожу функцию void,  которая проверяет условия палиндромности числа

// Console.Write("Введите пятизначное число - ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 10000 || num > 99999) Console.WriteLine("Недопустимое число!");
// else Func(num);
// Ввожу условие, при котором числа вне диапазона от 10000 до 100000 не рассматриваются,
// запрашию число в консоли терминала, присваиваю ему 32-рязрядный формат и запускаю функцию

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве. (+ 2D пространство из семинара)

// Console.WriteLine("Для выбора 2D пространства нажмите 1, для выбора 3D пространства нажмите 2 ");
// int select = Convert.ToInt32(Console.ReadLine());
// if (select == 1)
// {
//     Console.Write("Введите координату x1 - ");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату y1 - ");
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату x2 - ");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату y2 - ");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     double d = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
//     d = Math.Sqrt(d);
//     Console.WriteLine("Расстояние между точками = " + d);

// }
// else if (select == 2){
//     Console.Write("Введите координату x1 - ");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату y1 - ");
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату z1 - ");
//     int z1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату x2 - ");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату y2 - ");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату z2 - ");
//     int z2 = Convert.ToInt32(Console.ReadLine());
//     double d = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
//     d = Math.Sqrt(d);
//     Console.WriteLine("Расстояние между точками = " + d);
// }

// else Console.WriteLine("Указано недопустимое число");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Kub(int n){
//     int curr = 1;
//     while(curr<=n){
//         Console.Write(curr*curr*curr + ", ");
//         curr++;
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Kub(num);

