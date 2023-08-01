// 

Console.WriteLine("Enter your numbers ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"большее число {n1}, меньшее число {n2}");
}
else if (n1 < n2)
{
    Console.WriteLine($"большее число {n2}, меньшее число {n1}");
}
else {
    Console.WriteLine("Числа равны");
}