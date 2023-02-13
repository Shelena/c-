Random rnd = new Random();
int n = rnd.Next(1, 10);
int m = rnd.Next(1, 10);
int[,] array2D = new int[n, m];

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
            System.Console.Write(String.Format("{0, 8}", array[i, j]));
        }
        System.Console.WriteLine();
    }
}

void GetResult(int[,] a)
{
    int[] r = new int[a.GetLength(1)];
    int buf = 0;
    int min = int.MaxValue;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            buf = buf + a[i, j];
        }
        r[i] = buf;
        Console.WriteLine("Сумма " + (i + 1) + " строки: " + r[i]);
        if (r[i] < min)
        {
            min = r[i];
        }
    }
    Console.WriteLine("Минимальная сумма: " + min);
}

FillMyArray(array2D, rnd);
PrintMyArray(array2D);
GetResult(array2D);

