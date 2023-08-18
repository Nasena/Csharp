/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Задайте цифру от 1 до 7:");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if (DayNumber <= 7 && DayNumber >= 6)
{
    Console.WriteLine($"День {DayNumber} - является выходным");
}

else if (DayNumber>0 && DayNumber<8)
{
    Console.WriteLine($"День {DayNumber} - будний день");
}

else if (DayNumber>7)
{
    Console.WriteLine("Вы ввели не число не от 1 до 7");
}