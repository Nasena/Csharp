/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
*/

Console.WriteLine("Введите Число N: ");

int numberN = Convert.ToInt32(Console.ReadLine());
double result = 0;
if (numberN < 0)
{
    numberN = numberN * (-1);
}
for (int i = 1; i <= numberN; i++)
{
    result = Math.Pow(i, 2);
    Console.WriteLine(result);
}