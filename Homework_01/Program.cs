﻿/*
// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

int num1;
int num2;       
// Объявление переменных

Console.WriteLine("Введите число 1: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
num2 = Convert.ToInt32(Console.ReadLine());   
//Запрос на введение чисел в терминале 
//Считываение чисел из строк терминала и их преобразование в 32-х битный формат

int max = num1;
// Объявление максимальным числом значение первой переменной

if(num2 > max) max = num2;
// Ветвление, при котором сравниваем значение второй переменной с максимальным значением


Console.Write("Максимальное число: ");
Console.WriteLine(max);
// Вывод в терминал максимального значения

int min = num1;
if (num2 < min) min = num2;
Console.Write("Минимальное число: ");
Console.WriteLine(min);
// По аналогии с нахождением максимального значения находим минимальное


// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.

int num1;
int num2;
int num3;      
// Объявление переменных

Console.WriteLine("Введите число 1: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
num2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число 3: ");
num3 = Convert.ToInt32(Console.ReadLine());   
//Запрос на введение чисел в терминале      
//Считываение чисел из строк терминала и их преобразование в 32-х битный формат

int max = num1;
// Объявление максимальным числом значение первой переменной

if (num2 > max) max = num2;
if (num3 > max) max = num3;
// Ветвление, при котором сравниваем значение второй и третьей переменной с максимальным значением
// при выполнении неравенства присваиваем значение текущей переменной переменной max


Console.Write("Максимальное число: ");
Console.WriteLine(max);
// Вывод в терминал максимального значения


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

int a;
// Обозначаем переменную а как целое число

Console.WriteLine("Введите число: ");
// Запрашиваем число из терминала

a = Convert.ToInt32(Console.ReadLine());
// считываем переменную а из терминала и преобразуем в 32-разрядное число
 
if ((a % 2 ) == 0) {

    Console.WriteLine("Число четное");
}
// Проверяем остаток от деления с помощью оператора %
// если остаток равен 0, то число четное, что и выводим в терминал
else {
    Console.WriteLine("Число нечетное");
}
//если остаток от деления не равен 0, то число нечетное


//Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int a;
// Обозначаем переменную а как целое число

Console.WriteLine("Введите число: ");
// Запрашиваем число из терминала

a = Convert.ToInt32(Console.ReadLine());
// считываем переменную а из терминала и преобразуем в 32-разрядное число
 
int current = 2;
// так как нам необходимо выводить четные числа, 
//то возьмем ближайшее четное к 1, которым является 2

while(current <= a){
    Console.Write(current + " ");
    current = current + 2;
}
// до тех пор пока current меньше или равен а
// выводим значение current, потом увеличиваем его на 2 и повторяем цикл


//Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int a;
// вводим переменную а

Console.WriteLine("Введите число: ");
// запрашиваем значение переменной в терминале

a = Convert.ToInt32(Console.ReadLine());
//считываем значение переменной из терминала и преобразуем в 32-разрядный формат

int current = 1;
// вводим переменную current и задаем ей значение начала интересующего интервала

while (current <= a){
    // запускаем цикл (до тех пор пока current меньше или равно а делай следующее)
    if ((current % 2) == 0){
       Console.Write(current + "; ");
       current = current + 2; 
    }
    // если переменная current четное, то выводи в терминал его значения, 
    // каждый проход цикла увеличиваем current на 2 (т.к. нас интересуют только четные числа)
    else {
        current++;
    }
    // если переменная current нечетное число, то увеличиваем на 1 и отправляем в начало цикла
}


*/
