/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
*/

Console.WriteLine("Введите Число A: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SumOfNumber(int number)
{
    int sum = 0;

for (int i = 1; i <= userNumber; i++)
{
sum += i;
}
    return sum;
}

System.Console.WriteLine($"Сумма чисел в числе {userNumber} равна - {SumOfNumber(userNumber)}");