/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите числа A и B: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int ProductOfNumber(int a, int b)
{
     int product = 1;
     {
          for (int i = 1; i <= b; i++)
          {
               product = product * a;
          }
     }
     return product;
}

if (numberB > 0)
{
     System.Console.WriteLine($"Число {numberA} в степени {numberB} равно - {ProductOfNumber(numberA, numberB)}");
}
else 
{
     Console.WriteLine("Вы ввели отрицательную степень");
}

