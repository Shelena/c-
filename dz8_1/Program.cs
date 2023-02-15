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

FillMyArray(array2D, rnd);
PrintMyArray(array2D);

void GetResult(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {

                if (array[i, j] <= array[i, k]) continue;
                int buf = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = buf;
            }
        }
    }
}

GetResult(array2D);
Console.WriteLine("*******");
PrintMyArray(array2D);