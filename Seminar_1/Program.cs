int num;

// Ввод данных
Console.Write("Введите число: ");

// Вычисление квадрата
num = Convert.ToInt32(Console.ReadLine());

int square = num * num;

if (square >= 100){
    Console.WriteLine("ОГО! Большой квадрат " + square);
}
else{
    Console.WriteLine("Квадрат числа " + square);
}

