Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
while (a >= 1000)
{
    a /= 10;
}
if (a < 100)
{
    Console.WriteLine("третьего числа нет");
}
else
{
    int num = a % 10;
    Console.Write("третье число:");
    Console.WriteLine(num);
}





//i = 0
//x = 2345 / 10 = 234
//i = i + 1 = 1
//x = 234 / 10 = 23
//i = i + 1 = 2
//x = 23 / 10 = 2
//i = i + 1 = 3
//x = 2 / 10 = 0
//if x = 0
//rez = i - 2


