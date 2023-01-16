Console.WriteLine("Введите число a");
string chislo_a = Console.ReadLine();
Console.WriteLine("Введите число b");
string chislo_b = Console.ReadLine();
Console.WriteLine("Введите число c");
string chislo_c = Console.ReadLine();
int a = int.Parse(chislo_a);
int b = int.Parse(chislo_b);
int c = int.Parse(chislo_c);
int max = a;
if (a > b)
{
    max = a;
    Console.WriteLine("максимальное число a");
}
else if (b > c)
{
    max = b;
    Console.WriteLine("максимальное число b");
}
else
{
    max = c;
    Console.WriteLine("максимальное число c");
}