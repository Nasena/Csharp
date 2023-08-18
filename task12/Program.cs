/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.

34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

/*int number1 = new Random().Next(1, 100);
Console.WriteLine(number1);
int number2 = new Random().Next(1, 10);
Console.WriteLine(number2);*/

int result = number1 % number2;

if (result == 0) 
{
    Console.WriteLine("Второе число кратное первому");
}

else
{
    Console.WriteLine($"Остаток от деления: {result}");
}