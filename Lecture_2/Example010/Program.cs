int[] array = { 41, 38, 83, 54, 5, 96, 7, 38, 9 };

int n = array.Length;
int find = 38;

int index = 0;

while(index < n){
    if (array[index] == find){
        Console.WriteLine(index);
        break;
    }

    index++;
}