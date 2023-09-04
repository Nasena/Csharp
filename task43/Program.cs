/*
Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 * x +
b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем


Система уравнений, чтобы вывести х:

y = k1*x +b1          k2*x + b2 = k1*x +b1          k2*x-k1*x = b1 - b2          x(k2-k1)= b1 - b2          x=(b1-b2)/(k2-k1)
y = k2*x + b2         y = k2*x + b2                 y = k2*x + b2                y = k2*x + b2              y = k2*x + b2

*/

Console.WriteLine("Введите значения b1, k1, b2, k2: ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());


double x = (b1-b2)/(k2-k1);
double y = k2*x + b2;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Прямые заданные уравнениями y={k1}*x+{b1} y={k2}*x+{b2} пересекутся в точке с координатами ({x} : {y})");
Console.ForegroundColor = ConsoleColor.White;