/*
 Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
*/

Console.Clear();

int[,] GetRandom2DArray(int row, int column, int min, int max) 
{
    int[,] result = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i,j] = new Random().Next(min, max);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
     System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i,j] +"\t");
        }
        System.Console.WriteLine();
    }
}

void AverageFromColumn(int[,] array)
{
    double sum = 0;
    System.Console.WriteLine();
    System.Console.Write($"[ ]\t");
    

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write($"{Math.Round(sum /array.GetLength(0),1)}\t");
         Console.ForegroundColor = ConsoleColor.White;
    }
}


int[,] randomArray = GetRandom2DArray(7, 5, -5, 10);
Print2DArray(randomArray);


AverageFromColumn(randomArray);
