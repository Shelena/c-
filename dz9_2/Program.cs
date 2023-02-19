Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

void GetSum(int m, int n, int res)
{
    if (m > n)
    {
        Console.WriteLine(res);
        return;
    }
    res = res + (m++);
    GetSum(m, n, res);
}
GetSum(m, n, 0);