/* Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y) */

Console.WriteLine("Напишите номер четверти 1,2,3 или 4");

int UserNumber = Convert.ToInt32(Console.ReadLine());

if (UserNumber == 1)
{
    Console.WriteLine (" X>0; Y>0");
}

else if (UserNumber == 2)
{
    Console.WriteLine ("X<0; Y>0");
}

else if (UserNumber == 3)
{
    Console.WriteLine ("X<0 ; Y<0 ");
}

else if (UserNumber == 4)
{
    Console.WriteLine ("X>0; Y<0");
}
else 
{
    Console.WriteLine ("Четверти не существует");
}