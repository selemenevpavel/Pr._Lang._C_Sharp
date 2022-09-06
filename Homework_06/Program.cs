// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int CountPosEl(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }
// int[] array = { 18, 43, -95, 0, 0, 3, 18, 565456565, -955995 }; //Место введения чисел с клавиатуры (через запятую)
// int positive = CountPosEl(array);
// Console.WriteLine($"Positive numbers is {positive}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// void SendPoint(double k1, double b1, double k2, double b2)
// {
//     if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают. Бесконечное число точек пересечения.");
//     else if (k1 == k2) Console.WriteLine("Прямые параллельны. Отсутствует точка пересечения.");
//     else
//     {
//         double x = ((b1 - b2) / (k2 - k1));
//         double y = (k1 * (b1 - b2) / (k2 - k1) + b1);
//         // Решив систему уравнений нашли уравнение для вывода координат (x; y)
//         Console.WriteLine($"Координаты точки пересечения ({x}; {y})");
//     }
// }
// Console.WriteLine("Введите k1");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b1");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2");
// int b2 = Convert.ToInt32(Console.ReadLine());

// SendPoint(k1, b1, k2, b2);