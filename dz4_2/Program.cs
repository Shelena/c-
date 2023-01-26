Console.WriteLine("Введите число");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int rezult = 0;
for (int i = 0; n > 0; i++)
{
    rezult = rezult + n % 10;
    n = n / 10;
}
Console.Write("Сумма цифр:");
Console.WriteLine(rezult);