/* 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


*/

Console.WriteLine("Введите координаты двух точек: ");

int numberX1 = Convert.ToInt32(Console.ReadLine());
int numberY1 = Convert.ToInt32(Console.ReadLine());
int numberX2 = Convert.ToInt32(Console.ReadLine());
int numberY2 = Convert.ToInt32(Console.ReadLine());

double numberXY = Math.Sqrt((numberX2 - numberX1)*(numberX2 - numberX1) + (numberY2-numberY1)*(numberY2-numberY1));
double roundedNumber = Math.Round(numberXY, 2); 
Console.WriteLine(roundedNumber);