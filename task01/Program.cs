/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
*/


Console.WriteLine("Введите числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number2 * number2;
if (result == number1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}