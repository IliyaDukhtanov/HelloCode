// Показать треугольник Паскаля. 
// Сделать вывод в виде равнобедренного треугольника.

int row = 128;   // пять строчек для треугольника
int[,] triangle = new int[row, row];  // двумерный массив
const int cellWidth = 1;   // количество символов, отводимое на один элемент

void FillTriangle()       // метод заполнения массива
{
    for (int i = 0; i < row; i++) 
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];  // заполняется элемент, находящийся над ним и над ним слева
        }
    }
}
void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");  // все, что ненудевое, будет напечатано
        }
        Console.WriteLine();
    }
}
void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            //if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}"); // отступ количества свободных ячеек, необходимого для равнобедренного треугольника
            if (triangle[i, j] % 2 != 0) Console.WriteLine("*"); //  вывод звёздочек
            col += cellWidth * 2;
        }

        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}
FillTriangle();
//PrintTriangle();
Console.ReadLine();
Magic();