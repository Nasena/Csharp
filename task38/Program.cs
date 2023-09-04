/*

Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

*/

Console.Clear();

double[] GetRandomArray(int arrayLength1, double start, double end)
{
    double[] array = new double[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (end - start) + start;
    }
    return array;
}

void PrintArray(double[] arrayToPrint)
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


double[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);

double minimalnoe = userArray[0];
double maximalnoe = userArray[0];
for (int i = 1; i < arrayL; i++)
{
    if (userArray[i] < minimalnoe) minimalnoe = userArray[i];
    else if (userArray[i] > maximalnoe) maximalnoe = userArray[i];
}
Console.WriteLine();
Console.WriteLine($"Разница между макс и мин элементом массива - {Math.Round(maximalnoe-minimalnoe,2)}");






