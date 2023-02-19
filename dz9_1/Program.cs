Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("*****");
void NumberCounter(int n)
{
    if (n == 0) return;
    Console.WriteLine(n);
    NumberCounter(n - 1);
}
NumberCounter(num);
