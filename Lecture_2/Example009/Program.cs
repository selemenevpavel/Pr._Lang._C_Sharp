int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0   1   2    3   4   5    6   7   8  - номера элементов массива
int[] first = new int[9] { 11, 22, 223, 45, 55, 869, 87, 98, 19 };
first[0] = 12;
Console.WriteLine(first[0]);


int max = Max(
    Max(first[0], first[1], first[2]),
    Max(first[3], first[4], first[5]),
    Max(first[6], first[7], first[8]));


Console.WriteLine(max);