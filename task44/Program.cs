/*
Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
Console.Clear();
Console.WriteLine("Задайте N:");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void Fibonacci(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    Console.Write($"{array[0]} {array[1] +" "}");

    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        Console.Write(array[i]+" ");
    }
    
}

Fibonacci(array);
