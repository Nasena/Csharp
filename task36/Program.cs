/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start,end);
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
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int Sum(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2==1)
    {
        sum = sum + array[i];
    }
}
return sum;
}

int[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);
int sumofelements = Sum(userArray);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях - {sumofelements}");