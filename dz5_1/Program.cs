int[] myArray = new int[10];
Random rnd = new Random();
int res = 0;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(0, 999);
    Console.Write(myArray[i] + " ,");
    int buf = myArray[i] % 2;
    if (buf == 0)
    {
        res = res + 1;
    }
}
Console.Write(System.Environment.NewLine + "количество четных чисел: " + res + System.Environment.NewLine);