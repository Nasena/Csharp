/*
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
*/
Console.Clear();


double[,] GetRandom2DArray(int row, int column, double min, double max) 
{
    double[,] result = new double [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i,j] = Math.Round((new Random().NextDouble() * (max - min) + min), 1);
        }
    }
    return result;
}

void Print2DArray(double[,] arrayToPrint)
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
double[,] randomArray = GetRandom2DArray(7, 5, -5, 10);
Console.ForegroundColor = ConsoleColor.Blue;
Print2DArray(randomArray);
Console.ForegroundColor = ConsoleColor.White;