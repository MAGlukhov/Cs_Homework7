// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows,columns];

void FillAndShowArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void AverageColumn(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            count += array[j,i];
        }
        Console.Write(count / array.GetLength(0) + "\t");
        count = 0;
    }
}



FillAndShowArray(matrix);
Console.WriteLine();
AverageColumn(matrix);