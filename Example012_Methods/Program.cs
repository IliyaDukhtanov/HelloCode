// Методы

// Вид1
/*void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();*/


//Вид2
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0; 
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "Новый текст");*/ // при использовании поименнованных переменных порядок обращения к ним не важен


//Вид3
/*int Method3() // если метод возвращает данные, нужно указанть тип данных, которые мы ожидаем
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);*/


//Вид4
/*string Method4(int count, string text)
{
    int i = 0; 
    string result = string.Empty; //начальная пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(10, "qwerty, ");
//Console.WriteLine(res);*/

//**********************************
// Цикл FOR
/*string Method4(int count, string text)
{
    string result = string.Empty; //начальная пустая строка
    for (int i = 0; i < 10; i++)
        {
        result = result + text;  
    }
    return result;
}
string res = Method4(10, "qwerty, ");
Console.WriteLine(res);*/

// Вывод таблицы умножения на экран
/*Console.Clear();
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}*/


// ==========Работа с текстом
/* Дан текст. В тексте нужно заменить все пробелы чёрточками, 
маленькие буквы "к" большими "К",
а большие "С" заменить маленькими "с"*/

// Ясна ли задача??

/*Console.Clear();
string text = "- Я думаю, - сказал князь, что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = qwerty
//            01
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ' , '|'); 
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к' , 'К'); // далее используем изменённый текст
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С' , 'с');
Console.WriteLine(newText);*/


// Алгоритм сортировки методом выбора
// Пример сортировки по возрастанию
/*int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}  

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)   // отнимаем 1 т.к. при поиске максимального значения ниже прибавляем 1
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)  // Поиск максимального элемента и перенос его 
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporarry = array[i];                 // перемена местами позиций
        array[i] = array[minPosition];
        array[minPosition] = temporarry;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);*/


// ДЗ - адапритровать код для сортировки по убыванию

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}  

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)   // отнимаем 1 т.к. при поиске максимального значения ниже прибавляем 1
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)  // Поиск максимального элемента и перенос его 
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporarry = array[i];                 // перемена местами позиций
        array[i] = array[maxPosition];
        array[maxPosition] = temporarry;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);