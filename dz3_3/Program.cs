Console.WriteLine("Введите число");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] myArray = new int[n];
for (int i = 0; i < n; i++)
{
    int rez = i + 1;
    rez = rez * rez * rez;
    myArray[i] = rez;
}
Console.WriteLine("Таблица кубов:");
for (int i = 0; i < n; i++)
{
    Console.Write(myArray[i]);
    Console.Write(", ");
}