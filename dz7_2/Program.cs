Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[,] array2D = new int[m, n];

void FillMyArray(
    int[,] array,
    Random rnd,
    int min = 0,
    int max = 100
)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
}

void PrintMyArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(String.Format("{0, 10}", array[i, j]));
        }
        System.Console.WriteLine();
    }
}

FillMyArray(array2D, rnd);
PrintMyArray(array2D);

Console.WriteLine("Введите двузначное число:");
int x = Convert.ToInt32(Console.ReadLine());
int MyIndexI = x % 10;
int MyIndexJ = x / 10;
Console.WriteLine("элемент на " + MyIndexI + "строке, в " + MyIndexJ + "столбце");
if (MyIndexI < n & MyIndexJ < m)
{
    Console.WriteLine(array2D[MyIndexI - 1, MyIndexJ - 1]);
}
else Console.WriteLine("Такого элемента нет");

