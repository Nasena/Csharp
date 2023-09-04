/*
Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте, а первый - на
последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

Console.Clear();

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

int[] TurnArray(int[] arrayForTurn)
{
    int temp = 0;
    for (int i = 0; i < arrayForTurn.Length/2; i++)
    {
       temp = arrayForTurn[i];
       arrayForTurn [i] = arrayForTurn [arrayForTurn.Length -i -1];
       arrayForTurn [arrayForTurn.Length -i -1] = temp;
    }
    return arrayForTurn;
}

System.Console.WriteLine("Введите длину массива и границы: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = FillArray(arrayL, min, max);
Console.ForegroundColor=ConsoleColor.Blue;
PrintArray(userArray);
Console.WriteLine();
int[] turnArray = TurnArray(userArray);
Console.ForegroundColor=ConsoleColor.Green;
PrintArray (turnArray);
Console.ForegroundColor=ConsoleColor.White;
