double[] myArray;
Console.WriteLine("введите размерность массива");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
myArray = new double[n];
Random rnd = new Random();
double min = double.MaxValue;
double max = double.MinValue;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.NextDouble();
    Console.Write(myArray[i] + " ,");

}
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > max)
    {
        max = myArray[i];
    }
    if (myArray[i] < min)
    {
        min = myArray[i];
    }
}
double res = max - min;
Console.WriteLine(System.Environment.NewLine + "min: " + min);
Console.WriteLine("max: " + max);
Console.WriteLine("max - min: " + res);