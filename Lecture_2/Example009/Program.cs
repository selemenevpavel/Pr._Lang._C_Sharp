int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0   1   2    3   4   5    6   7   8  - номера элементов массива
int[] array { 11, 22, 223, 45, 55, 869, 87, 98, 19 }
array[0] = 12;
Console.WriteLine(array[0]);


int max = Max(
    Max(array[0], array[1], array[2]));


Console.WriteLine(max);