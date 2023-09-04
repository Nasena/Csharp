/*
Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

string Delenie(int a)
{
    string result = String.Empty;
    int temp = 0;
    for (int i = a; i > 0; i/=2)
    {
        temp = i%2;
        result = temp + result;
    }
    return result;
}

Console.WriteLine(Delenie(a));