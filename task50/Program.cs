/*
Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
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

void GetNumberFromArray(int[,] array, int row, int column)
{
    if (row <= array.GetLength(0) && column <= array.GetLength(1)) System.Console.WriteLine($"Значение элемента в [{row}] строке и [{column}] столбце соответсвует {array[row, column]}");
    else Console.WriteLine("Элемента с такими индексами в массиве нет.");
}



int[,] randomArray = GetRandom2DArray(7, 5, -5, 10);
Console.ForegroundColor = ConsoleColor.Blue;
Print2DArray(randomArray);
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Введите индекс строки элемента массива, который хотите найти:");
int userRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца элемента массива, который хотите найти:");
int userColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
GetNumberFromArray(randomArray, userRow, userColumn);
Console.ForegroundColor = ConsoleColor.White;