/*
 Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
 */

 Console.WriteLine("Введите Число N: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Multiplication(int number)
{
    int multiplication = 1;
    for (int i = 1; i <= userNumber; i++)
{
multiplication = multiplication*i;
}
    
    return multiplication;
}

Console.WriteLine(Multiplication(userNumber));