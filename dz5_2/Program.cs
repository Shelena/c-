int[] myArray = new int[5];
Random rnd = new Random();
int res = 0;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(-9, 9);
    Console.Write(myArray[i] + " ,");

}
for (int i = 1; i < myArray.Length; i = i + 2)
{
    res = res + myArray[i];
}
Console.Write(System.Environment.NewLine + "сумма чисел на нечетных позициях: " + res + System.Environment.NewLine);
