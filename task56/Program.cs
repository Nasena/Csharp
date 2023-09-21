/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int[,] GetRandom2DArray(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(min, max);
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
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] SumFromRows(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows[i] += array[i, j];
        }
    }
    return sumRows;
}



int MinSumRow(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[min])
        {
            min = i;
        }
    }
    return min;
}


int[,] userArray = GetRandom2DArray(7, 5, -5, 10);
Print2DArray(userArray);

System.Console.WriteLine();
System.Console.WriteLine($"Строка с наименьшей суммой элементов - {MinSumRow(SumFromRows(userArray))}");

