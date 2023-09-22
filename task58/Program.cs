/*
 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

Console.Clear();

int[,] GetRandom2DArray(int rowNumber, int columnsNumber, int min, int max)
{
    int[,] result = new int[rowNumber, columnsNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnsNumber; j++)
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
        Console.Write($"[{i}] \t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}] \t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

bool CheckSize(int[,] matrix1, int[,] matrix2)
{
    bool checking = true;
     if (matrix1.GetLength(1) != matrix2.GetLength(0)) checking = false;
    return checking;
}

int[,] MartrixProd(int[,] matrix1, int[,] matrix2)
{
    int[,] prod = new int[matrix1.GetLength(0),matrix2.GetLength(1)]; // в случае несогласованных массивов возвращает массив из нулей
    if (CheckSize(matrix1, matrix2)) 
    {
        for (int i = 0; i < prod.GetLength(0); i++)
        {
            for (int j = 0; j < prod.GetLength(1); j++)
            {
                prod[i,j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    prod[i,j] += matrix1[i,k] * matrix2[k,j];
                }
            }
        }
    } 
    return prod;
}

int[,] userArray1 = GetRandom2DArray(2,3,0,10);
int[,] userArray2 = GetRandom2DArray(3,2,0,10);
Print2DArray(userArray1);
Print2DArray(userArray2);
Print2DArray(MartrixProd(userArray1,userArray2));