/*
Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.
*/

int[] FillArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] CopyArray(int[] array)
{
    int [] copyArray = new int [array.Length];
    for (int i = 0; i < copyArray.Length; i++)
    {
       copyArray[i] = array[i];
    }
    return copyArray;
}

System.Console.WriteLine("Введите длину массива и границы: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = FillArray(arrayL, min, max);
Console.ForegroundColor=ConsoleColor.Blue;
PrintArray(userArray);
Console.WriteLine();
int[] copyArray = CopyArray(userArray);
Console.ForegroundColor=ConsoleColor.Green;
PrintArray (copyArray);
Console.ForegroundColor=ConsoleColor.White;
