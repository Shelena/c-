Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
double[,] array2D = new double[m, n];

void FillMyArray(
    double[,] array,
    Random rnd,
    double min = -10,
    double max = 10
)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(min + rnd.NextDouble() * (max - min), 1);
        }
    }
}

void PrintMyArray(double[,] array)
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