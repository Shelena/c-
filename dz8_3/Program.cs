Random rnd = new Random();
int n1 = rnd.Next(1, 10);
int m1 = rnd.Next(1, 10);
int n2 = m1;
int m2 = rnd.Next(1, 10);
int[,] array1 = new int[n1, m1];
int[,] array2 = new int[n2, m2];

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

static void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i, j]);
        }
        Console.WriteLine();
    }
}

static int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

FillMyArray(array1, rnd);
FillMyArray(array2, rnd);
Print(array1);
Console.WriteLine("********");
Print(array2);
Console.WriteLine("Результат:");
//Multiplication(array1, array2);
Print(Multiplication(array1, array2));