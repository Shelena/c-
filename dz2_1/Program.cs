Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int rez = (a / 10 * 10 - a / 100 * 100) / 10;
Console.WriteLine(rez);