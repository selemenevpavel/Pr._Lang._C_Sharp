﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// void SecondNumber(){
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine("Number is - " + num);

// Переменной num присваиваем случайное число в диапазоне [100; 1000) (100 включаем, 100 не включаем)

//     int a = num / 100;
//     int result1 = num - a * 100;
//     int result = result1 / 10;
//     Console.WriteLine("Second number is - " + result);
// } 
// SecondNumber();

//  Переменной а присваиваем рязряд сотен и вычисляем значение
//  После чего отнимаем от нашего числа количество сотен и получаем result1
//  Далее переменной result присваиваем разряд десятков, который является вторым и искомым


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// int num;
// Console.Write("Number is - ");
// num = Convert.ToInt32(Console.ReadLine());

// запрашиваем в терминале значение переменной num и определяем для нее 32-рязрядный формат

// if (num > 99){
//     Console.WriteLine("Third number - " + num.ToString()[2]);
// }
// else{
//     Console.WriteLine("Third digit is missing");
// }

// Если выполняется условие, для которого num больше 99, выводим в терминал третий слева символ строки
// в противном случае третья цифра в числе отсутствует


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// int num;
// Console.Write("Number is - ");
// num = Convert.ToInt32(Console.ReadLine());

// запрашиваем в терминале значение переменной num и определяем для нее 32-рязрядный формат

// if (num > 0 && num < 8){
//     if (num > 5){
//         Console.WriteLine("Day off");
//     }
//     if (num < 6){
//         Console.WriteLine("Working day");
//     }
// }
// else{
//     Console.WriteLine("Invalid number");
// }

// В ветвлении проверяем несколько условий:
// 1. число лежит в диапазоне от 1 до 7 включительно, иначе такого дня нет
// 2. если число в диапазоне от 1 до 5 включительно, рабочие дни
// 3. если число равно 6 или 7, то дни выходные
