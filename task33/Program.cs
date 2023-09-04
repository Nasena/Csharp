/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

*/

Console.Clear();

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int [] arrayToPrint)
{
    Console.Write("[");
    for (int i=0; i<arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i]);
       if (i<arrayToPrint.Length - 1)
       {
        Console.Write (", ");
       }
    }
    Console.Write("]");
}



System.Console.WriteLine("Задайте длину массива и границы: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int number = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);

bool FindUserNumber(int[] array, int number)
{
    bool number1 = false;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i]==number)
        {
            number1 = true;
        }
    }
    return number1;
}

bool number1 = FindUserNumber(userArray, number);
Console.WriteLine();
if (number1==true) Console.WriteLine($"Число {number} - есть в массиве");
else Console.WriteLine($"Числа {number} - НЕТ в массиве");