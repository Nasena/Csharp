/*
Задайте значение N. 
Напишите программу, которая выдает все натуральные числа в промежутке от од 1 до N
*/

void NaturalNum(int n, int start = 1)
{
    if (start <= n)
    {
        System.Console.Write(start + ",");
        NaturalNum(n, start+1);
    }

}

NaturalNum(5);