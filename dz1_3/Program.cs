Console.WriteLine("Введите число");
string chislo = Console.ReadLine();
int a = int.Parse(chislo);
int b = a % 2;
if (b == 0)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число нечетное");
}