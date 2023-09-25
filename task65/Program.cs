/*
Задайте значения M  и N. Напишите программу, которая выдает натуральные числа от M до N
*/


void NaturalNum(int m, int n)
{
    if (m<n)
    {
        System.Console.Write(m + ",");
        NaturalNum(m+1, n);
    }
}

NaturalNum(1,5);