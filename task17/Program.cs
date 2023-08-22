/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. */

Console.WriteLine("Введите координаты X и Y: ");

int numberX = Convert.ToInt32(Console.ReadLine());
int numberY = Convert.ToInt32(Console.ReadLine());

if (numberX >0 && numberY >0)
{
    Console.WriteLine ($"Точка [{numberX}:{numberY}] находится в 1 четверти");
}

else if (numberX<0 && numberY>0)
{
    Console.WriteLine ($"Точка [{numberX}:{numberY}] находится во 2 четверти");
}
else if (numberX<0 && numberY<0)
{
    Console.WriteLine ($"Точка [{numberX}:{numberY}] находится в 3 четверти");
}
else if (numberX>0 && numberY<0)
{
    Console.WriteLine ($"Точка [{numberX}:{numberY}] находится в 4 четверти");
}