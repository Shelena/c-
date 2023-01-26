int[] myArray = new int[8];
Console.WriteLine("Введите 8 чисел");
for (int i = 0; i < 8; i++)
{
    int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    myArray[i] = n;
}
Console.Write("Получился массив: [");
for (int i = 0; i < 8; i++)
{
    Console.Write(myArray[i]);
}
Console.WriteLine("]");