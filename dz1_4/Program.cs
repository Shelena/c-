Console.WriteLine("Введите число");
string chislo = Console.ReadLine();
int a = int.Parse(chislo);
int x = 1;
int y = 1;
for (int i = 0; i < a; i++)
{
    x = a - i;
    y = x % 2;
    if (y == 0)
    {
        Console.Write(x);
        Console.Write(",");
    }
}