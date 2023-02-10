int n = 5;
int m = 5;
int[,] array2D = new int[n, m];

void FillMyArray(
    int[,] array
)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
        }
    }
}

void PrintMyArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(String.Format("{0, 5}", array[i, j]));
        }
        System.Console.WriteLine();
    }
}

void SpiralFillMatrix(int[,] A)
{
    int s = 0, e = Math.Min(A.GetLength(0), A.GetLength(1)), r = 0, c = -1, ev = e * e;
    string dir = "Right";

    for (int v = 1; v <= ev; v++)
    {
        switch (dir)
        {
            case "Right":
                if (++c >= e)
                {
                    dir = "Down";
                    r++;
                    c--;
                }
                break;
            case "Down":
                if (++r >= e)
                {
                    dir = "Left";
                    c--;
                    r--;
                }
                break;
            case "Left":
                if (--c < s)
                {
                    dir = "Up";
                    r--;
                    c++;
                }
                break;
            case "Up":
                if (--r <= s)
                {
                    dir = "Right";
                    s++;
                    e--;
                    c = s;
                    r++;
                }
                break;
        }
        A[r, c] = v;
    }
}

FillMyArray(array2D);
PrintMyArray(array2D);
Console.WriteLine("***");
SpiralFillMatrix(array2D);
PrintMyArray(array2D);

