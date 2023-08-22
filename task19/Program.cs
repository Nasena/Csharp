/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int startNumber = userNumber / 1000;
Console.WriteLine(startNumber);

int endNumber = userNumber % 100;
Console.WriteLine(endNumber);

if (startNumber == (endNumber - (endNumber / 10) * 10) * 10 + endNumber / 10)
/*
Чтобы реверсировать число воспользовалась формулой:
Первая цифра двухзначного числа = а = Число/10
Вторая цифра двухзначного числа = б = число - а*10
Реверс.числа = б*10 + а
Я разворачивала последние две цифры пятизначного числа. Думаю, задачу можно решить и наборот разворачивая первые цифры пятизначного числа.
*/
{
Console.WriteLine($"Число {userNumber} - является палиндромом");
}
   
else
{
   Console.WriteLine($"Число {userNumber} - не является палиндромом");
}

