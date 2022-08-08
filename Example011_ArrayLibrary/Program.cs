void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10); // положить случайное число от 0 до 9 в массив collection
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOF(int[] collection, int find) // поиск позиции определённого числа в массиве
{
    int count = collection.Length;
    int index = 0; 
    int position = -1;  // значение -1 для элементов, которых точно не будет в массиве
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; // создать новый массив из 10-ти элементов

FillArray(array); // заполнить массив случайными числами
PrintArray(array);   // распечатать заполненный массив
Console.WriteLine(); // пустая строчка

int pos = indexOF(array, 4); // найти позицию числа 4 в массиве
Console.WriteLine(pos);