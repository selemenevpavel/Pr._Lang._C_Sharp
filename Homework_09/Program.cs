// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// //Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }

// //Рекурсия числа от M до N
// string RecursMToN(int numM, int numN)
// {
//     if (numN <= numM)
//     {
//         return numM + "";
//     }
//     else
//     {
//         string outLine = numM + ", " + RecursMToN(numM + 1, numN);
//         return outLine;
//     }
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int inputNumM = ReadData("Введите число M: ");
// int inputNumN = ReadData("Введите число N: ");
// string outLine = (inputNumM < inputNumN) ? RecursMToN(inputNumM, inputNumN) : RecursMToN(inputNumN, inputNumM);
// PrintData("Числа от " + inputNumM + " до " + inputNumN + ": ", outLine);

// ----------------------------------------------------------------------------------------------

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }

// //Рекурентная сумма чисел от M до N
// int SumMToN(int numM, int numN)
// {
//     if (numN <= numM)
//     {
//         return numM;
//     }
//     else
//     {
//         int sum = numM + SumMToN(numM + 1, numN);
//         return sum;
//     }
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int inputNumM = ReadData("Введите число M: ");
// int inputNumN = ReadData("Введите число N: ");
// int sum = 0;
// sum = (inputNumM < inputNumN) ? SumMToN(inputNumM, inputNumN) : SumMToN(inputNumN, inputNumM);
// PrintData($"Сумма чисел от {inputNumM} до {inputNumN} равна: ", sum.ToString());

// ---------------------------------------------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// // Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }

// //Функция Аккермана для чисел M и N
// int AkkermanFunc(int numM, int numN)
// {
//     if (numM == 0) return numN + 1;
//     if (numM != 0 && numN == 0) return AkkermanFunc(numM - 1, 1);
//     if (numM > 0 && numN > 0) return AkkermanFunc(numM - 1, AkkermanFunc(numM, numN - 1));
//     return AkkermanFunc(numM, numN);

// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int inputNumM = ReadData("Введите число M: ");
// int inputNumN = ReadData("Введите число N: ");
// int res = AkkermanFunc(inputNumM, inputNumN);
// PrintData("A(m,n) = ", res.ToString());
