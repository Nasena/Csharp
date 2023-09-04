/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

int[] GetRandomArray(int arrayLength1)
{
    int[] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

System.Console.WriteLine("Введите длинну массива: ");
int arrayL = Convert.ToInt32(Console.ReadLine());


int QuantityNumber(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
    {
        count++;
    }
}
return count;
}

int[] userArray = GetRandomArray(arrayL);
PrintArray(userArray);
int kolichestvo = QuantityNumber(userArray);
Console.WriteLine();
Console.WriteLine($"Количество чётных элементов в массиве - {kolichestvo}");