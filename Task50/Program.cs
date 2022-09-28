// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер строки");
int numberRow = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int numberColumn = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows,columns];

void FillAndShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void CheckPosition(int[,] array, int row, int column)
{
    if(row >= array.GetLength(0) || column >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ваше число: " + array[row,column]);
    }
}


FillAndShowArray(matrix);
CheckPosition(matrix, numberRow, numberColumn);