Console.WriteLine("Введите число a");
string chislo_a = Console.ReadLine();
Console.WriteLine("Введите число b");
string chislo_b = Console.ReadLine();
int a = int.Parse(chislo_a);
int b = int.Parse(chislo_b);
int max = a;
if (a > b)
{
    max = a;
    Console.WriteLine("максимальное число a");
}
else
{
    max = b;
    Console.WriteLine("максимальное число b");
}
