/*
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

Console.Clear();

Console.Write("Задайте длинну массива:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте массив:");
int[] FillUserArray(int arrayLength)
{
    int[] array = new int[m];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("Массив пользователя: [");
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

int[] userArray = FillUserArray(m);

int PozitivCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.ForegroundColor = ConsoleColor.Blue;
PrintArray(userArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Положительных чисел в массиве - {PozitivCount(userArray)}");
Console.ForegroundColor = ConsoleColor.White;
