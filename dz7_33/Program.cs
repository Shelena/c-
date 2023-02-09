Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[,] array2D = new int[n, m];

void FillMyArray(
    int[,] array,
    Random rnd,
    int min = -100,
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


void GetResult(
    int[,] array
)

{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double buf = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            buf = buf + array[j, i];
        }
        buf = Math.Round(buf / array.GetLength(0), 2);
        Console.WriteLine("Среднее арифметическое " + (i + 1) + " столбца: " + buf);
    }
    // for (int j = 0; j < n; j++)
    // {
    //     double buf = 0;
    //     for (int i = 0; i < m; i++)
    //     {
    //         buf = Math.Round(buf + array[i, j], 2);
    //         Console.WriteLine(buf);
    //     }
    // }
}
GetResult(array2D);