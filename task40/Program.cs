/* 
Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

/*Console.Clear();

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

Console.WriteLine("Введите ")*/
Console.Clear();
Console.WriteLine("Введите длины сторон:");

int[] FillUserArray()
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

bool TriangleExistance(int[] array)
{
    if (array[0] < array[1] + array[2]
    && array[1] < array[0] + array[2]
    && array[2] < array[1] + array[0]) return true;

    else return false;
}


bool result = TriangleExistance(FillUserArray());
Console.Write(result);