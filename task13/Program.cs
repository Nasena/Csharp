/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6;
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 999)
{
    number = number / 10;
}
int numberThree = number % 10;

if (number>100)
{
    Console.WriteLine(numberThree);
}
else {
    Console.WriteLine("Третьей цифры нет");
}

