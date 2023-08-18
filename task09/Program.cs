/*
Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа
*/ 

int number = new Random().Next(10, 100);
Console.WriteLine(number);

int numberOne = number / 10;
Console.WriteLine(numberOne);

int numberTwo = number % 10;
Console.WriteLine(numberTwo);

if(numberOne > numberTwo)
{
    Console.WriteLine($"наибольшая цифра числа {number} - {numberOne}");
}
else
{
    Console.WriteLine($"наибольшая цифра числа {number} - {numberTwo}");
}