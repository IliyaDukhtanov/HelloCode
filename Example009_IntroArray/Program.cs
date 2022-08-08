int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// номера ячеек 0   1   2   3...
int[] array = {11, 12, 131, 41, 51, 61, 27, 38, 89};
/*array[0] = 12;                  // обратиться к массиву и записать значение
Console.WriteLine(array[0]);*/    // обратиться к массиву и вывести значение по индексу

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(max);