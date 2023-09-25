/*
Напишите программу, которая на вход принимает два числа A и B, и возводит число в целую степень B.

*/

int result = ProdNumber(2,4);
int ProdNumber(int a, int b)
{
    if (b == 1) return a;
    else
    return a*ProdNumber(a, b-1);
}

System.Console.Write(result);
