/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

Console.Clear();

int[,] Get2DArray(int cols, int rows, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
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
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int SumDiaganalArray(int[,] array)
{
    int result = 0;
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);
    int size = cols;
    if(cols > rows) size = rows;

    for (int i = 0; i < size; i++)
    {
        result += array[i,i];
    }
    return result;
}

int [,] arr = Get2DArray(10,3,0,10);
Print2DArray(arr);
System.Console.WriteLine();
System.Console.WriteLine(SumDiaganalArray(arr));